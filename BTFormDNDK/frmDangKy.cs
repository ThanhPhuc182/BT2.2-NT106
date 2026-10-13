using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTFormDNDK
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                hopLe = false;
            }

            if (cboChucVu.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboChucVu, "Vui lòng chọn chức vụ!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || txtSoDienThoai.Text.Length != 10)
            {
                errorProvider1.SetError(txtSoDienThoai, "Số điện thoại phải gồm đúng 10 chữ số!");
                hopLe = false;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải từ 6 ký tự trở lên!");
                hopLe = false;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không trùng khớp!");
                hopLe = false;
            }

            if (!hopLe) return;

            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                var db = new DatabaseService();

                bool daTonTai = await db.KiemTraTenDangNhapToanTaiAsync(txtTenDangNhap.Text.Trim());
                if (daTonTai)
                {
                    MessageBox.Show("Tên đăng nhập này đã có người sử dụng! Vui lòng chọn tên khác.",
                                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDangNhap.Focus();
                    return;
                }

                var (salt, bam) = MatKhau.Tao(txtMatKhau.Text);
                DateTime? ngaySinh = dtpNgaySinh.Checked ? dtpNgaySinh.Value : (DateTime?)null;

                bool thanhCong = await db.DangKyNguoiDungAsync(
                    txtTenDangNhap.Text.Trim(),
                    bam,
                    salt,
                    cboChucVu.SelectedItem.ToString(),
                    txtSoDienThoai.Text.Trim(),
                    txtCCCD.Text.Trim(),
                    ngaySinh
                );

                if (thanhCong)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Máy chủ cơ sở dữ liệu (SQL Server) hiện không sẵn sàng hoặc kết nối bị gián đoạn.\nVui lòng kiểm tra lại dịch vụ hệ thống!",
                                "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống trong quá trình đăng ký.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "ĐĂNG KÝ";
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e) { }
        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMatKhau_TextChanged(object sender, EventArgs e) { }
        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e) { }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e) { }
        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e) { }
        private void txtCCCD_TextChanged(object sender, EventArgs e) { }
    }
}