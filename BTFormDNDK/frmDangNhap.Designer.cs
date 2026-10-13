namespace BTFormDNDK
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            chkHienMatKhau = new CheckBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lblDangKy = new LinkLabel();
            lblLoi = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 141);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 234);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(180, 178);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(417, 27);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(180, 270);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(417, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(179, 317);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(148, 24);
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.Text = "Hiển thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(251, 378);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(103, 29);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(446, 378);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Location = new Point(395, 321);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(202, 20);
            lblDangKy.TabIndex = 3;
            lblDangKy.TabStop = true;
            lblDangKy.Text = "Chưa có tài khoản? ĐĂNG KÝ";
            lblDangKy.LinkClicked += lblDangKy_LinkClicked;
            // 
            // lblLoi
            // 
            lblLoi.AutoSize = true;
            lblLoi.ForeColor = Color.Red;
            lblLoi.Location = new Point(250, 344);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(0, 20);
            lblLoi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 67);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 9;
            label3.Text = "QUẢN LÝ HIỆU THUỐC";
            // 
            // frmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 162, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblLoi);
            Controls.Add(lblDangKy);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(chkHienMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private CheckBox chkHienMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel lblDangKy;
        private Label lblLoi;
        private Label label3;
    }
}
