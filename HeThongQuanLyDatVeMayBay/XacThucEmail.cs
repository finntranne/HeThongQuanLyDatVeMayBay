using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyDatVeMayBay
{
    public partial class XacThucEmail : Form
    {
        private readonly DatabaseHelper dbHelper;
        private readonly string userEmail;
        private int countdownTime = 300; // 5 phút (300 giây)
        private Timer timer;
        public XacThucEmail(DatabaseHelper dbHelper, string userEmail)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            this.userEmail = userEmail;
        }

        private void XacThucEmail_Load(object sender, EventArgs e)
        {
            StartCountdown();
        }
        private void StartCountdown()
        {
            timer = new Timer();
            timer.Interval = 1000; // Mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateLabel();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countdownTime > 0)
            {
                countdownTime--;
                UpdateLabel();
            }
            else
            {
                timer.Stop();
                btnGuiLaiEmail.Enabled = true; // Kích hoạt lại nút gửi OTP
                lbDemNguoc.Text = ""; // Hiển thị lại thông báo
            }
        }
        private void UpdateLabel()
        {
            int minutes = countdownTime / 60;
            int seconds = countdownTime % 60;
            lbDemNguoc.Text = $"{minutes:D2}:{seconds:D2}";
        }
        private void btnXacThucEmail_Click(object sender, EventArgs e)
        {
            string userOtp = MaOTP.Text.Trim();

            if (string.IsNullOrEmpty(userOtp))
            {
                MessageBox.Show("Vui lòng nhập mã OTP!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dbHelper.XacThucMaOtp(userOtp))
            {
                MessageBox.Show("Xác minh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuiLaiEmail_Click(object sender, EventArgs e)
        {

            if (countdownTime > 0)
            {
                MessageBox.Show("Vui lòng đợi hết thời gian đếm ngược trước khi gửi lại OTP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string otp = dbHelper.TaoMaOtp();
                dbHelper.GuiOtpDenEmail(userEmail, otp);
                MessageBox.Show("Mã OTP mới đã được gửi đến email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset lại thời gian đếm ngược
                countdownTime = 120;
                btnGuiLaiEmail.Enabled = false;
                StartCountdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi lại mã OTP: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoatEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQuayLai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
