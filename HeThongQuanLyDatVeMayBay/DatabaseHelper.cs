using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace HeThongQuanLyDatVeMayBay
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=.;Initial Catalog=QLDVMB;Integrated Security=True;";
        private string storedOtp;
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool dangKiTaiKhoan(string ho, string ten, string soDienThoai, DateTime ngaySinh, string email, string matKhau)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO KhachHang (Ho, TenDemVaTen, SoDienThoai, NgaySinh, Email, MatKhau) " +
                                  "VALUES (@Ho, @Ten, @SoDienThoai, @NgaySinh, @Email, @MatKhau)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ho", ho);
                        command.Parameters.AddWithValue("@Ten", ten);
                        command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng ký tài khoản: " + ex.Message);
            }
        }

        public bool emailTonTai(string email)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM KhachHang WHERE Email = @Email"; // Sửa bảng thành KhachHang
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra email: " + ex.Message);
            }
        }

        public bool sdtTonTai(string soDienThoai)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai"; // Sửa bảng thành KhachHang
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra số điện thoại: " + ex.Message);
            }
        }

        public static bool matKhauManh(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        public static bool KiemTraDu18Tuoi(DateTime ngaySinh)
        {
            DateTime ngayHienTai = DateTime.Today;
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngaySinh.Date > ngayHienTai.AddYears(-tuoi))
            {
                tuoi--;
            }
            return tuoi >= 18;
        }

        public bool KiemTraDangNhap(string soDT, string matKhau)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Lấy tất cả số điện thoại từ cơ sở dữ liệu
                    string query = "SELECT SoDienThoai, MatKhau FROM KhachHang";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dbSoDienThoai = reader["SoDienThoai"].ToString();
                                string dbMatKhau = reader["MatKhau"].ToString();

                                // Chuẩn hóa số điện thoại từ cơ sở dữ liệu thành định dạng bắt đầu bằng 0
                                string standardizedDbSoDT = ChuanHoaSoDienThoaiDangNhap(dbSoDienThoai);

                                // So sánh số điện thoại người dùng nhập với số đã chuẩn hóa
                                if (standardizedDbSoDT == soDT && dbMatKhau == matKhau)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    return false; // Không tìm thấy tài khoản khớp
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
                }
            }
        }

        // Hàm chuẩn hóa số điện thoại từ cơ sở dữ liệu thành định dạng bắt đầu bằng 0
        private string ChuanHoaSoDienThoaiDangNhap(string dbSoDienThoai)
        {
            if (string.IsNullOrEmpty(dbSoDienThoai) || !dbSoDienThoai.StartsWith("+"))
            {
                return dbSoDienThoai; // Trả về nguyên bản nếu không có mã quốc gia
            }

            // Tìm mã quốc gia từ danh sách CountryPhoneRules
            var matchingRule = CountryPhoneRules.Rules.FirstOrDefault(r => dbSoDienThoai.StartsWith(r.CountryCode));
            if (matchingRule == null)
            {
                return dbSoDienThoai; // Không tìm thấy mã quốc gia, trả về nguyên bản
            }

            // Loại bỏ mã quốc gia và thêm số 0 vào đầu
            string soDienThoaiWithoutCountryCode = dbSoDienThoai.Substring(matchingRule.CountryCode.Length);
            return "0" + soDienThoaiWithoutCountryCode;
        }

        public string TaoMaOtp()
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999); // Tạo mã 6 chữ số
            storedOtp = otp.ToString();
            return storedOtp;
        }

        public bool GuiOtpDenEmail(string email, string otp)
        {
            try
            {
                // Cấu hình email gửi
                string fromEmail = "vnwingsairlines@gmail.com"; // Email của bạn
                string fromPassword = "ujoh pskz frnz oszc"; // Mật khẩu ứng dụng

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(email);
                mail.Subject = "Mã OTP Xác Thực Tài Khoản";
                mail.Body = $"Mã OTP của bạn là: <b>{otp}</b>. Mã này có hiệu lực trong 5 phút.";

                mail.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, fromPassword);

                smtpClient.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gửi email OTP: " + ex.Message);
            }
        }

        // Xác minh mã OTP
        public bool XacThucMaOtp(string userOtp)
        {
            return userOtp == storedOtp;
        }

    }
}