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
    public partial class frmQuanLyCongVanDen : Form
    {
        public frmQuanLyCongVanDen()
        {
            InitializeComponent();
        }

        private void frmQuanLyCongVanDen_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();

            // Hiển thị Form TrangChủ
            frm.Show();

            // Đóng Form hiện tại
            this.Close();
        }

        private void tBTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
