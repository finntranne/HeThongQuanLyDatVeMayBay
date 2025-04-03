using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SiticoneNetFrameworkUI;
using System.Net.Mail;

namespace HeThongQuanLyDatVeMayBay
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            cbHoTro.Items.Add("Hỗ trợ");
            cbHoTro.Items.Add("Liên hệ");
            cbHoTro.Items.Add("Hỏi đáp");
            cbHoTro.Items.Add("Góp ý");
            cbHoTro.SelectedIndex = 0;
            
            RadioButton_KhuHoi();
            RadioButton_MotChieu();

            rbKhuHoi.CheckedChanged += rbKhuHoi_CheckedChanged;
            rbMotChieu.CheckedChanged += rbMotChieu_CheckedChanged;
        }

        private void lblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            DialogResult result = formDangNhap.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                FormNguoiDung formNguoiDung = new FormNguoiDung();
                formNguoiDung.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide();
                formNguoiDung.Show();
            }


        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 0.9; 
            FormDangKy formDangKy = new FormDangKy();
            DialogResult result = formDangKy.ShowDialog();
            this.Opacity = 1;
            if (result == DialogResult.OK)
            {
                this.Opacity = 0.9;
                FormDangNhap formDangNhap = new FormDangNhap();
                DialogResult dangNhapResult = formDangNhap.ShowDialog();
                this.Opacity = 1;
                if (dangNhapResult == DialogResult.OK)
                {
                    FormNguoiDung formNguoiDung = new FormNguoiDung();
                    formNguoiDung.FormClosed += (s, args) =>
                    {
                        this.Show();
                        this.Opacity = 1;
                    };
                    this.Hide();
                    formNguoiDung.Show();
                }
            }

        }

        private void KichHoatChucNangSauDangNhap()
        {
            //btnDatVe.Enabled = true;  // Bật chức năng đặt vé
            //btnQuanLy.Enabled = true; // Bật chức năng quản lý
            //lblTenNguoiDung.Text = "Xin chào, Admin"; // Cập nhật giao diện
        }
        private void RadioButton_KhuHoi()
        {
            rbKhuHoi.Checked = true;
            rbKhuHoi.TextColor = Color.White;
            rbKhuHoi.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbKhuHoi.CheckedColor = Color.Gold;

            rbKhuHoi.CheckedChanged += radioButton_KhuHoi_CheckedChanged;
        }
        private void radioButton_KhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            rbKhuHoi.TextColor = rbKhuHoi.Checked ? Color.White : Color.LightGray;
        }
        private void RadioButton_MotChieu()
        {
            rbMotChieu.Checked = false;
            rbMotChieu.TextColor = Color.LightGray;
            rbMotChieu.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbMotChieu.CheckedColor = Color.Gold;

            rbMotChieu.CheckedChanged += radioButton_MotChieu_CheckedChanged;
        }
        private void radioButton_MotChieu_CheckedChanged(object sender, EventArgs e)
        {
            rbMotChieu.TextColor = rbMotChieu.Checked ? Color.White : Color.LightGray;
        }
        private void rbMotChieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMotChieu.Checked)
            {
                dtpNgayVe.Enabled = false; // Làm mờ DateTimePicker Ngày Về
                dtpNgayVe.FillColor = Color.LightGray; // Thay đổi màu nền cho dễ phân biệt
            }
        }

        private void rbKhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKhuHoi.Checked)
            {
                dtpNgayVe.Enabled = true; // Hiện lại DateTimePicker Ngày Về
                dtpNgayVe.FillColor = Color.White; // Đưa về màu trắng như ban đầu
            }
        }

        
    }
}
