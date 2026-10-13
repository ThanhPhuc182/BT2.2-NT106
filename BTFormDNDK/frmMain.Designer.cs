namespace BTFormDNDK
{
    partial class frmMain
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
            lblXinChao = new Label();
            lblThongTin = new Label();
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Location = new Point(228, 135);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(50, 20);
            lblXinChao.TabIndex = 0;
            lblXinChao.Text = "label1";
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(228, 218);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(50, 20);
            lblThongTin.TabIndex = 1;
            lblThongTin.Text = "label1";
            lblThongTin.Click += lblThongTin_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(340, 322);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(94, 29);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangXuat);
            Controls.Add(lblThongTin);
            Controls.Add(lblXinChao);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblXinChao;
        private Label lblThongTin;
        private Button btnDangXuat;
    }
}