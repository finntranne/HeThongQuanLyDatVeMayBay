namespace HeThongQuanLyDatVeMayBay
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.siticoneShimmerLabel1 = new SiticoneNetFrameworkUI.SiticoneShimmerLabel();
            this.lbTaiKhoan = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.labMatKhau = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkboxMatKhau = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblQuenMatKhau = new SiticoneNetFrameworkUI.SiticoneLinkedLabel();
            this.toggleGhiNho = new SiticoneNetFrameworkUI.SiticoneToggleSwitch();
            this.lbGhiNho = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.panelNen = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbTroVe = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lblTroVe = new SiticoneNetFrameworkUI.SiticoneLinkedLabel();
            this.lbLoiDangNhap = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // siticoneShimmerLabel1
            // 
            this.siticoneShimmerLabel1.AutoReverse = false;
            this.siticoneShimmerLabel1.BaseColor = System.Drawing.Color.Black;
            this.siticoneShimmerLabel1.Direction = SiticoneNetFrameworkUI.ShimmerDirection.LeftToRight;
            this.siticoneShimmerLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneShimmerLabel1.IsAnimating = true;
            this.siticoneShimmerLabel1.IsPaused = false;
            this.siticoneShimmerLabel1.Location = new System.Drawing.Point(84, 12);
            this.siticoneShimmerLabel1.Name = "siticoneShimmerLabel1";
            this.siticoneShimmerLabel1.PauseDuration = 0;
            this.siticoneShimmerLabel1.ShimmerColor = System.Drawing.Color.Cyan;
            this.siticoneShimmerLabel1.ShimmerOpacity = 1F;
            this.siticoneShimmerLabel1.ShimmerSpeed = 50;
            this.siticoneShimmerLabel1.ShimmerWidth = 0.2F;
            this.siticoneShimmerLabel1.Size = new System.Drawing.Size(340, 50);
            this.siticoneShimmerLabel1.TabIndex = 0;
            this.siticoneShimmerLabel1.Text = "Đăng nhập";
            this.siticoneShimmerLabel1.ToolTipText = "";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(8, 79);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(327, 30);
            this.lbTaiKhoan.TabIndex = 1;
            this.lbTaiKhoan.Text = "Số điện thoại di động/ Email";
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSoDT.BorderRadius = 10;
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.DefaultText = "";
            this.txtSoDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.FocusedState.BorderColor = System.Drawing.Color.Lime;
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Location = new System.Drawing.Point(13, 115);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PlaceholderText = "Số điện thoại/ Email...";
            this.txtSoDT.SelectedText = "";
            this.txtSoDT.ShadowDecoration.BorderRadius = 10;
            this.txtSoDT.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.txtSoDT.ShadowDecoration.Depth = 10;
            this.txtSoDT.ShadowDecoration.Enabled = true;
            this.txtSoDT.Size = new System.Drawing.Size(457, 40);
            this.txtSoDT.TabIndex = 2;
            // 
            // labMatKhau
            // 
            this.labMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.labMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatKhau.Location = new System.Drawing.Point(8, 161);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(127, 30);
            this.labMatKhau.TabIndex = 3;
            this.labMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BorderRadius = 10;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.Lime;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(13, 197);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderText = "Mật khẩu...";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.BorderRadius = 10;
            this.txtMatKhau.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.txtMatKhau.ShadowDecoration.Depth = 10;
            this.txtMatKhau.ShadowDecoration.Enabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(411, 40);
            this.txtMatKhau.TabIndex = 4;
            // 
            // checkboxMatKhau
            // 
            this.checkboxMatKhau.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.checkboxMatKhau.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.checkboxMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("checkboxMatKhau.Image")));
            this.checkboxMatKhau.ImageOffset = new System.Drawing.Point(0, 0);
            this.checkboxMatKhau.ImageRotate = 0F;
            this.checkboxMatKhau.ImageSize = new System.Drawing.Size(40, 40);
            this.checkboxMatKhau.Location = new System.Drawing.Point(431, 194);
            this.checkboxMatKhau.Name = "checkboxMatKhau";
            this.checkboxMatKhau.Size = new System.Drawing.Size(39, 43);
            this.checkboxMatKhau.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoRoundedCorners = true;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(170, 342);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(154, 42);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuenMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(279, 249);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(191, 23);
            this.lblQuenMatKhau.TabIndex = 8;
            this.lblQuenMatKhau.TabStop = true;
            this.lblQuenMatKhau.Text = "Quên mật khẩu?";
            this.lblQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toggleGhiNho
            // 
            this.toggleGhiNho.AccessibleDescription = "A customizable toggle switch that can be turned on or off.";
            this.toggleGhiNho.AccessibleName = "Siticone Toggle Switch";
            this.toggleGhiNho.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.toggleGhiNho.AnimationRipple = true;
            this.toggleGhiNho.CanBeep = true;
            this.toggleGhiNho.CanShake = true;
            this.toggleGhiNho.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toggleGhiNho.DisallowToggling = false;
            this.toggleGhiNho.EnableGlowEffect = true;
            this.toggleGhiNho.EnableHoverAnimation = true;
            this.toggleGhiNho.EnablePressAnimation = true;
            this.toggleGhiNho.EnableRippleEffect = true;
            this.toggleGhiNho.ExtraThumbSize = 2;
            this.toggleGhiNho.IsReadOnly = false;
            this.toggleGhiNho.IsRequired = false;
            this.toggleGhiNho.LabelColor = System.Drawing.Color.Black;
            this.toggleGhiNho.LabelFont = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleGhiNho.Location = new System.Drawing.Point(17, 246);
            this.toggleGhiNho.Logger = null;
            this.toggleGhiNho.Name = "toggleGhiNho";
            this.toggleGhiNho.OffAnimationSpeed = 115;
            this.toggleGhiNho.OffBackColor1 = System.Drawing.Color.Silver;
            this.toggleGhiNho.OffBackColor2 = System.Drawing.Color.Silver;
            this.toggleGhiNho.OffBorderColor1 = System.Drawing.Color.Silver;
            this.toggleGhiNho.OffBorderColor2 = System.Drawing.Color.Silver;
            this.toggleGhiNho.OffIcon = null;
            this.toggleGhiNho.OffThumbColor1 = System.Drawing.Color.White;
            this.toggleGhiNho.OffThumbColor2 = System.Drawing.Color.White;
            this.toggleGhiNho.OnAnimationSpeed = 115;
            this.toggleGhiNho.OnBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.toggleGhiNho.OnBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.toggleGhiNho.OnBorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.toggleGhiNho.OnBorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.toggleGhiNho.OnIcon = null;
            this.toggleGhiNho.OnThumbColor1 = System.Drawing.Color.White;
            this.toggleGhiNho.OnThumbColor2 = System.Drawing.Color.White;
            this.toggleGhiNho.PreventToggleOff = false;
            this.toggleGhiNho.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toggleGhiNho.RippleExpansionRate = 2F;
            this.toggleGhiNho.RippleOpacityDecay = 0.02F;
            this.toggleGhiNho.Size = new System.Drawing.Size(46, 26);
            this.toggleGhiNho.TabIndex = 9;
            this.toggleGhiNho.ToggleOffSoundPath = "";
            this.toggleGhiNho.ToggleOnSoundPath = "";
            this.toggleGhiNho.ToolTipText = "";
            this.toggleGhiNho.TrackDeviceTheme = true;
            // 
            // lbGhiNho
            // 
            this.lbGhiNho.BackColor = System.Drawing.Color.Transparent;
            this.lbGhiNho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbGhiNho.ForeColor = System.Drawing.Color.Blue;
            this.lbGhiNho.Location = new System.Drawing.Point(69, 246);
            this.lbGhiNho.Name = "lbGhiNho";
            this.lbGhiNho.Size = new System.Drawing.Size(187, 23);
            this.lbGhiNho.TabIndex = 10;
            this.lbGhiNho.Text = "Ghi nhớ tài khoản";
            // 
            // panelNen
            // 
            this.panelNen.FillColor = System.Drawing.Color.Cyan;
            this.panelNen.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.panelNen.FillColor3 = System.Drawing.Color.Fuchsia;
            this.panelNen.FillColor4 = System.Drawing.Color.DeepPink;
            this.panelNen.Location = new System.Drawing.Point(513, 0);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(486, 600);
            this.panelNen.TabIndex = 11;
            // 
            // lbTroVe
            // 
            this.lbTroVe.BackColor = System.Drawing.Color.Transparent;
            this.lbTroVe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroVe.ForeColor = System.Drawing.Color.Blue;
            this.lbTroVe.Location = new System.Drawing.Point(12, 524);
            this.lbTroVe.Name = "lbTroVe";
            this.lbTroVe.Size = new System.Drawing.Size(70, 48);
            this.lbTroVe.TabIndex = 25;
            this.lbTroVe.Text = "←";
            this.lbTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTroVe.Click += new System.EventHandler(this.lbTroVe_Click);
            // 
            // lblTroVe
            // 
            this.lblTroVe.BackColor = System.Drawing.Color.Transparent;
            this.lblTroVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroVe.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblTroVe.Location = new System.Drawing.Point(59, 533);
            this.lblTroVe.Name = "lblTroVe";
            this.lblTroVe.Size = new System.Drawing.Size(100, 39);
            this.lblTroVe.TabIndex = 26;
            this.lblTroVe.TabStop = true;
            this.lblTroVe.Text = "Trở về";
            this.lblTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTroVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTroVe_LinkClicked);
            // 
            // lbLoiDangNhap
            // 
            this.lbLoiDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbLoiDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoiDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbLoiDangNhap.Location = new System.Drawing.Point(13, 286);
            this.lbLoiDangNhap.Name = "lbLoiDangNhap";
            this.lbLoiDangNhap.Size = new System.Drawing.Size(457, 43);
            this.lbLoiDangNhap.TabIndex = 31;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbLoiDangNhap);
            this.Controls.Add(this.lblTroVe);
            this.Controls.Add(this.lbTroVe);
            this.Controls.Add(this.panelNen);
            this.Controls.Add(this.lbGhiNho);
            this.Controls.Add(this.toggleGhiNho);
            this.Controls.Add(this.lblQuenMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.checkboxMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.labMatKhau);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.siticoneShimmerLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private SiticoneNetFrameworkUI.SiticoneShimmerLabel siticoneShimmerLabel1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDT;
        private Guna.UI2.WinForms.Guna2ImageCheckBox checkboxMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private SiticoneNetFrameworkUI.SiticoneLabel labMatKhau;
        private Guna.UI2.WinForms.Guna2TileButton btnDangNhap;
        private SiticoneNetFrameworkUI.SiticoneToggleSwitch toggleGhiNho;
        private SiticoneNetFrameworkUI.SiticoneLinkedLabel lblQuenMatKhau;
        private SiticoneNetFrameworkUI.SiticoneLabel lbGhiNho;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelNen;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTroVe;
        private SiticoneNetFrameworkUI.SiticoneLinkedLabel lblTroVe;
        private SiticoneNetFrameworkUI.SiticoneLabel lbLoiDangNhap;
    }
}