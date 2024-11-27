using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCONGVAN
{
    public partial class frmTrangChu : Form
    {
        QLCVDataContext db = new QLCVDataContext();
        Table<frmTrangChu> trangchus;
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void congvanden_Click(object sender, EventArgs e)
        {

        }

        private void congvandi_Click(object sender, EventArgs e)
        {
            frmQuanLyCongVanDi frm = new frmQuanLyCongVanDi();
            frm.Show();
            this.Hide();
        }

        private void congvanden_Click_1(object sender, EventArgs e)
        {
            frmQuanLyCongVanDen frm = new frmQuanLyCongVanDen();
            frm.Show();
            this.Hide();
        }

        private void quanlitaikhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.Show(); 
            this.Hide();    
        }

        private void phanquyen_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.Show(); 
            this.Hide();
        }

        //private void pheduyet_Click(object sender, EventArgs e)
        //{
        //    frmPheDuyet frm = new frmPheDuyet();    
        //    frm.Show(); 
        //    this.Hide();    
        //}

        private void coquan_Click(object sender, EventArgs e)
        {
            frmDanhSachCoQuan frm  = new frmDanhSachCoQuan();
            frm.Show();
            this.Hide();
        }

        private void phongban_Click(object sender, EventArgs e)
        {
            frmDanhSachPhongBan frm = new frmDanhSachPhongBan();
            frm.Show();
            this.Hide();
        }

        private void thongbao_Click(object sender, EventArgs e)
        {
            frmThongBaoVaNhacNho frm = new frmThongBaoVaNhacNho();
            frm.Show();
            this.Hide();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();  
            frm.Show();
            this.Hide();
        }

        private void congvandi_Click_1(object sender, EventArgs e)
        {
            frmQuanLyCongVanDi frm = new frmQuanLyCongVanDi();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
