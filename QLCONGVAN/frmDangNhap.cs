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
        private bool KiemTraDangNhap(string username, string password)
        {
            using (QLCVDataContext db = new QLCVDataContext())
            {
                var user = db.DANGNHAPs
                             .FirstOrDefault(u => u.tenDangNhap == username && u.matKhau == password);
                return user != null;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = DangNhap.Text.Trim();
            string password = MatKhau.Text.Trim();

            if (KiemTraDangNhap(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
