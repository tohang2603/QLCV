using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCONGVAN
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            string username = TbDangNhap.Text;
            string password = tBMatKhau.Text;

            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);

            if (username == "admin" && password == "congvan") // Đây là ví dụ đơn giản
            {
                // Đăng nhập thành công, mở form chính
                frmTrangChu mainForm = new frmTrangChu();
                mainForm.Show();  // Mở form chính
                this.Hide();      // Ẩn form đăng nhập
            }
            else
            {
                // Thông báo lỗi nếu thông tin đăng nhập sai
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại.");
            }
        }

        private void TbDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
