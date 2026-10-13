using System;
using System.Windows.Forms;

namespace BTFormDNDK
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy f = new frmDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblLoi.Text = "";

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!";
                return;
            }

            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";

            try
            {
                var db = new DatabaseService();
                var user = await db.LayThongTinDangNhapAsync(txtTenDangNhap.Text.Trim());

                if (user == null || !MatKhau.KiemTra(txtMatKhau.Text, user.Value.Salt, user.Value.MatKhauBam))
                {
                    lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                    txtMatKhau.Clear();
                    return;
                }

                await db.CapNhatLanDangNhapCuoiAsync(txtTenDangNhap.Text.Trim());

                frmMain mainForm = new frmMain(txtTenDangNhap.Text.Trim(), user.Value.ChucVu);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            catch (Microsoft.Data.SqlClient.SqlException)
            {
                
                MessageBox.Show("Máy chủ cơ sở dữ liệu (SQL Server) hiện không sẵn sàng hoặc đã bị dừng.\nVui lòng kiểm tra lại dịch vụ hệ thống!",
                                "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
          
                MessageBox.Show("Đã xảy ra lỗi không xác định trong quá trình xử lý.",
                                "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "ĐĂNG NHẬP";
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e) { }
        private void txtMatKhau_TextChanged(object sender, EventArgs e) { }
    }
}