using System;
using System.Windows.Forms;

namespace BTFormDNDK
{
    public partial class frmMain : Form
    {
        public frmMain(string tenDangNhap, string chucVu)
        {
            InitializeComponent();
            lblXinChao.Text = $"Xin chào: {tenDangNhap}";
            lblThongTin.Text = $"Chức vụ: {chucVu} | Đăng nhập lúc: {DateTime.Now:dd/MM/yyyy HH:mm}";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}