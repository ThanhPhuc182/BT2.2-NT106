namespace BTFormDNDK
{
    partial class frmDangKy
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
            components = new System.ComponentModel.Container();
            lblTieuDeDangKy = new Label();
            label1 = new Label();
            txtTenDangNhap = new TextBox();
            txtSoDienThoai = new TextBox();
            label2 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtCCCD = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label7 = new Label();
            cboChucVu = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeDangKy
            // 
            lblTieuDeDangKy.AutoSize = true;
            lblTieuDeDangKy.Location = new Point(337, 25);
            lblTieuDeDangKy.Name = "lblTieuDeDangKy";
            lblTieuDeDangKy.Size = new Size(153, 20);
            lblTieuDeDangKy.TabIndex = 8;
            lblTieuDeDangKy.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 73);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập *";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(154, 104);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(225, 27);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(153, 261);
            txtSoDienThoai.MaxLength = 10;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(225, 27);
            txtSoDienThoai.TabIndex = 3;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 227);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 13;
            label2.Text = "Số điện thoại *";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(153, 179);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(225, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 148);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu *";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(153, 342);
            txtCCCD.MaxLength = 12;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(225, 27);
            txtCCCD.TabIndex = 5;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 305);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 15;
            label4.Text = "Số CCCD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 73);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 10;
            label5.Text = "Chức vụ *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 148);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 12;
            label6.Text = "Xác nhận mật khẩu *";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(450, 179);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(248, 27);
            txtXacNhanMatKhau.TabIndex = 2;
            txtXacNhanMatKhau.TextChanged += txtXacNhanMatKhau_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 227);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 14;
            label7.Text = "Ngày sinh";
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Dược sĩ", "Thủ kho" });
            cboChucVu.Location = new Point(451, 104);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(247, 28);
            cboChucVu.TabIndex = 1;
            cboChucVu.SelectedIndexChanged += cboChucVu_SelectedIndexChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(448, 261);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 4;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(366, 396);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(565, 396);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDangKy
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 162, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(dtpNgaySinh);
            Controls.Add(cboChucVu);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCCCD);
            Controls.Add(label4);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label2);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label1);
            Controls.Add(lblTieuDeDangKy);
            Name = "frmDangKy";
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeDangKy;
        private Label label1;
        private TextBox txtTenDangNhap;
        private TextBox txtSoDienThoai;
        private Label label2;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtCCCD;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtXacNhanMatKhau;
        private Label label7;
        private ComboBox cboChucVu;
        private DateTimePicker dtpNgaySinh;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}