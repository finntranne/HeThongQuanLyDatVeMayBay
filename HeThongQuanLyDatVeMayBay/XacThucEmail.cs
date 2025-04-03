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
        public XacThucEmail(DatabaseHelper dbHelper, string userEmail)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            this.userEmail = userEmail;
        }

        private void XacThucEmail_Load(object sender, EventArgs e)
        {
        }

        private void btnXacThucEmail_Click(object sender, EventArgs e)
        {
            string userOtp = txtMaOTP.Text.Trim();

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

            try
            {
                string otp = dbHelper.TaoMaOtp();
                dbHelper.GuiOtpDenEmail(userEmail, otp);
                MessageBox.Show("Mã OTP mới đã được gửi đến email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
