namespace HeThongQuanLyDatVeMayBay
{
    partial class XacThucEmail
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
            this.txtMaOTP = new System.Windows.Forms.TextBox();
            this.btnXacThucEmail = new System.Windows.Forms.Button();
            this.btnGuiLaiEmail = new System.Windows.Forms.Button();
            this.btnThoatEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaOTP
            // 
            this.txtMaOTP.Location = new System.Drawing.Point(253, 126);
            this.txtMaOTP.Name = "txtMaOTP";
            this.txtMaOTP.Size = new System.Drawing.Size(357, 22);
            this.txtMaOTP.TabIndex = 0;
            // 
            // btnXacThucEmail
            // 
            this.btnXacThucEmail.Location = new System.Drawing.Point(319, 210);
            this.btnXacThucEmail.Name = "btnXacThucEmail";
            this.btnXacThucEmail.Size = new System.Drawing.Size(198, 51);
            this.btnXacThucEmail.TabIndex = 1;
            this.btnXacThucEmail.Text = "Xác Thực";
            this.btnXacThucEmail.UseVisualStyleBackColor = true;
            this.btnXacThucEmail.Click += new System.EventHandler(this.btnXacThucEmail_Click);
            // 
            // btnGuiLaiEmail
            // 
            this.btnGuiLaiEmail.Location = new System.Drawing.Point(376, 297);
            this.btnGuiLaiEmail.Name = "btnGuiLaiEmail";
            this.btnGuiLaiEmail.Size = new System.Drawing.Size(78, 33);
            this.btnGuiLaiEmail.TabIndex = 2;
            this.btnGuiLaiEmail.Text = "Gửi Lại";
            this.btnGuiLaiEmail.UseVisualStyleBackColor = true;
            this.btnGuiLaiEmail.Click += new System.EventHandler(this.btnGuiLaiEmail_Click);
            // 
            // btnThoatEmail
            // 
            this.btnThoatEmail.Location = new System.Drawing.Point(36, 397);
            this.btnThoatEmail.Name = "btnThoatEmail";
            this.btnThoatEmail.Size = new System.Drawing.Size(98, 51);
            this.btnThoatEmail.TabIndex = 3;
            this.btnThoatEmail.Text = "Quay lại";
            this.btnThoatEmail.UseVisualStyleBackColor = true;
            this.btnThoatEmail.Click += new System.EventHandler(this.btnThoatEmail_Click);
            // 
            // XacThucEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 460);
            this.Controls.Add(this.btnThoatEmail);
            this.Controls.Add(this.btnGuiLaiEmail);
            this.Controls.Add(this.btnXacThucEmail);
            this.Controls.Add(this.txtMaOTP);
            this.Name = "XacThucEmail";
            this.Text = "XacThucEmail";
            this.Load += new System.EventHandler(this.XacThucEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaOTP;
        private System.Windows.Forms.Button btnXacThucEmail;
        private System.Windows.Forms.Button btnGuiLaiEmail;
        private System.Windows.Forms.Button btnThoatEmail;
    }
}