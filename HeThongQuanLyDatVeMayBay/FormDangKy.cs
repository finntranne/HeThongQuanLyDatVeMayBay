using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HeThongQuanLyDatVeMayBay.DatabaseHelper;

namespace HeThongQuanLyDatVeMayBay
{
    public partial class FormDangKy : Form
    {
        private readonly DatabaseHelper dbHelper;
        private ToolTip toolTip;
        private static readonly Random random = new Random();

        public FormDangKy()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            checkboxMatKhau.CheckedChanged += checkboxMatKhau_CheckedChanged;
            checkboxXacNhanMatKhau.CheckedChanged += checkboxXacNhanMatKhau_CheckedChanged;

            toolTip = new ToolTip();

            var sortedRules = CountryPhoneRules.Rules;
            foreach (var rule in sortedRules)
            {
                cbSDTQG.Items.Add(rule);
            }
            cbSDTQG.DisplayMember = "ToString";
            cbSDTQG.DropDownStyle = ComboBoxStyle.DropDownList;

            cbSDTQG.DropDownHeight = 200; // Giới hạn danh sách thả xuống hiển thị tối đa 5 mục

            cbSDTQG.SelectedIndex = sortedRules.FindIndex(r => r.CountryCode == "+84");

            cbSDTQG.SelectedIndexChanged += (s, args) =>
            {
                var selectedRule = (SoDienThoaiHopLe)cbSDTQG.SelectedItem;
                if (selectedRule != null)
                {
                    cbSDTQG.Text = $"({selectedRule.CountryCode})";
                    string tooltipText = $"Số điện thoại {selectedRule.CountryName}: {selectedRule.MinLength}-{selectedRule.MaxLength} chữ số";
                    if (selectedRule.ValidPrefixes != null && selectedRule.ValidPrefixes.Any())
                    {
                        tooltipText += $"\nĐầu số hợp lệ: {string.Join(", ", selectedRule.ValidPrefixes)}";
                    }
                    if (selectedRule.RemoveLeadingZero)
                    {
                        tooltipText += "\nBỏ số 0 ở đầu nếu có.";
                    }
                    toolTip.SetToolTip(cbSDTQG, tooltipText);
                }
            };

            txtMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.PasswordChar = '●';
        }

        private void checkboxMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = checkboxMatKhau.Checked ? '\0' : '●';
        }

        private void checkboxXacNhanMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = checkboxXacNhanMatKhau.Checked ? '\0' : '●';
        }

        private void lbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            lbLoiDangKi.Text = "";

            string ho = txtHo.Text;
            string ten = txtTenDemvaTen.Text;
            var selectedCountry = (SoDienThoaiHopLe)cbSDTQG.SelectedItem;
            if (selectedCountry == null)
            {
                lbLoiDangKi.Text = "Vui lòng chọn một quốc gia hợp lệ!";
                return;
            }
            string maQuocGia = selectedCountry.CountryCode;
            string countryName = selectedCountry.CountryName;
            string soDienThoai = txtSoDT.Text.Trim();
            string sdt = maQuocGia + soDienThoai;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string matKhau = txtMatKhau.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;

            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(soDienThoai) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                lbLoiDangKi.Text = "Vui lòng điền đầy đủ thông tin!";
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(soDienThoai, @"^\d+$"))
            {
                lbLoiDangKi.Text = "Số điện thoại không hợp lệ! Chỉ được chứa chữ số.";
                return;
            }

            var rule = CountryPhoneRules.layQuyTacSoDienThoaiTheoQuocGia(maQuocGia, countryName);
            if (rule == null)
            {
                lbLoiDangKi.Text = "Không tìm thấy quy tắc cho quốc gia này!";
                return;
            }

            if (rule.RemoveLeadingZero && soDienThoai.StartsWith("0"))
            {
                soDienThoai = soDienThoai.Substring(1);
                sdt = maQuocGia + soDienThoai;
            }

            if (soDienThoai.Length < rule.MinLength || soDienThoai.Length > rule.MaxLength)
            {
                lbLoiDangKi.Text = $"Số điện thoại {rule.CountryName} phải có từ {rule.MinLength} đến {rule.MaxLength} chữ số!";
                return;
            }

            if (rule.ValidPrefixes != null && rule.ValidPrefixes.Any())
            {
                bool isValidPrefix = false;
                foreach (var prefix in rule.ValidPrefixes)
                {
                    if (soDienThoai.StartsWith(prefix))
                    {
                        isValidPrefix = true;
                        break;
                    }
                }
                if (!isValidPrefix)
                {
                    lbLoiDangKi.Text = $"Đầu số điện thoại {rule.CountryName} không hợp lệ! Đầu số hợp lệ: {string.Join(", ", rule.ValidPrefixes)}.";
                    return;
                }
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lbLoiDangKi.Text = "Email không hợp lệ! Vui lòng nhập đúng định dạng (ví dụ: user@example.com).";
                return;
            }

            if (!matKhauManh(matKhau))
            {
                lbLoiDangKi.Text = "Mật khẩu không đủ mạnh!\nPhải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.";
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                lbLoiDangKi.Text = "Mật khẩu và xác nhận mật khẩu không khớp!";
                return;
            }

            if (dbHelper.emailTonTai(email))
            {
                lbLoiDangKi.Text = "Email đã tồn tại, vui lòng sử dụng email khác!";
                return;
            }

            if (dbHelper.sdtTonTai(sdt))
            {
                lbLoiDangKi.Text = "Số điện thoại đã tồn tại, vui lòng sử dụng số khác!";
                return;
            }

            if (!KiemTraDu18Tuoi(ngaySinh))
            {
                lbLoiDangKi.Text = "Bạn phải đủ 18 tuổi để đăng ký!";
                return;
            }
            try
            {
                string otp = dbHelper.TaoMaOtp();
                dbHelper.GuiOtpDenEmail(email, otp);

                XacThucEmail xacThucEmail = new XacThucEmail(dbHelper, email);
                DialogResult result = xacThucEmail.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool isSuccess = dbHelper.dangKiTaiKhoan(ho, ten, sdt, ngaySinh, email, matKhau);
                    if (isSuccess)
                    {
                        this.DialogResult = DialogResult.OK;
                        txtHo.Clear();
                        txtTenDemvaTen.Clear();
                        txtSoDT.Clear();
                        dtpNgaySinh.Value = DateTime.Now;
                        txtEmail.Clear();
                        txtMatKhau.Clear();
                        txtXacNhanMatKhau.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}