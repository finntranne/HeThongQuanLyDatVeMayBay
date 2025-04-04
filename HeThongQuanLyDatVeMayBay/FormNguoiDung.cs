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
    public partial class FormNguoiDung : Form
    {
        public FormNguoiDung()
        {
            InitializeComponent();
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, cpbNguoiDung.Width, cpbNguoiDung.Height);
            cpbNguoiDung.Region = new Region(path);

            RadioButton_KhuHoi();
            RadioButton_MotChieu();

            rbKhuHoi.CheckedChanged += rbKhuHoi_CheckedChanged;
            rbMotChieu.CheckedChanged += rbMotChieu_CheckedChanged;

        }

        private void cpbNguoiDung_Click(object sender, EventArgs e)
        {
            menuNguoiDung.Show(Cursor.Position);
        }

        private void DangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
