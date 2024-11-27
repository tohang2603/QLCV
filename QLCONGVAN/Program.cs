using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCONGVAN
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Check kiểm tra user đã đăng nhập hay chưa?
            // Đã đăng nhập rồi
            Application.Run(new frmTrangChu());
            // Chưa đăng nhập
            Application.Run(new frmDangNhap());
        }
    }
}
