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
    public partial class FormDangNhap : Form
    {
        private readonly DatabaseHelper dbHelper;
        public FormDangNhap()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        private void checkboxMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxMatKhau.Checked)
                txtMatKhau.PasswordChar = '\0'; // Hiện mật khẩu
            else
                txtMatKhau.PasswordChar = '●'; // Ẩn mật khẩu bằng dấu chấm
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
            checkboxMatKhau.CheckedChanged += checkboxMatKhau_CheckedChanged;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string soDT = txtSoDT.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(matKhau))
            {
                lbLoiDangNhap.Text = "Vui lòng nhập số điện thoại và mật khẩu!";
                return;
            }

            try
            {
                bool isValid = dbHelper.KiemTraDangNhap(soDT, matKhau);
                if (isValid)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); 
                    FormNguoiDung formNguoiDung = new FormNguoiDung();
                    formNguoiDung.ShowDialog();
                }
                else
                {
                    lbLoiDangNhap.Text = "Sai số điện thoại hoặc mật khẩu!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
