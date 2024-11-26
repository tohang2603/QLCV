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
    public partial class frmQuanLyCongVanDi : Form
    {
        QLCVDataContext db = new QLCVDataContext();
        Table<frmQuanLyCongVanDi> qlcvs;
        public frmQuanLyCongVanDi()
        {
            InitializeComponent();
        }
        public void loadCongVanDi()
        {
            //Nguồn dữ liệu
            IEnumerable<CONGVAN> cvs = db.CONGVANs;
            //Câu lệnh truy vấn Linq
            var query = from cv in cvs
                        select cv;

            //Thực thi câu lệnh truy vấn
            LCV.DataSource = query.ToList();
        }
        private void frmQuanLyCongVanDi_Load(object sender, EventArgs e)
        {
            //load lại dữ liệu 
            loadCongVanDi();
        }

        private void LCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = LCV.CurrentCell.RowIndex;
            // Gán giá trị của các cột vào các control tương ứng
            maCV.Text = LCV.Rows[index].Cells[0].Value.ToString();
            maCQ.Text = LCV.Rows[index].Cells[1].Value.ToString();
            maPB.Text = LCV.Rows[index].Cells[2].Value.ToString();
            maND.Text = LCV.Rows[index].Cells[3].Value.ToString();
            maLoaiCV.Text = LCV.Rows[index].Cells[4].Value.ToString();
            soCV.Text = LCV.Rows[index].Cells[5].Value.ToString();
            tieudecv.Text = LCV.Rows[index].Cells[6].Value.ToString();
            trichnd.Text = LCV.Rows[index].Cells[7].Value.ToString();
            // Chuyển giá trị ngày từ DataGridView vào DateTimePicker
            ngaytao.Value = Convert.ToDateTime(LCV.Rows[index].Cells["ngayTao"].Value);
            ngaycapnhat.Value = Convert.ToDateTime(LCV.Rows[index].Cells["ngayCapNhat"].Value);

            trangthai.Text = LCV.Rows[index].Cells[10].Value.ToString();
            nguoitao.Text = LCV.Rows[index].Cells[11].Value.ToString();
            nguoixuli.Text = LCV.Rows[index].Cells[12].Value.ToString();
            nguoipd.Text = LCV.Rows[index].Cells[13].Value.ToString();
            mucdokc.Text = LCV.Rows[index].Cells[14].Value.ToString();
            noinhan.Text = LCV.Rows[index].Cells[15].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng công văn mới
            CONGVAN congvan = new CONGVAN();

            try
            {
                // Gán giá trị từ giao diện vào đối tượng
                congvan.maCV = maCV.Text;
                congvan.maCQ = maCQ.Text;
                congvan.maPB = maPB.Text;
                congvan.maND = maND.Text;
                congvan.maLoaiCV = maLoaiCV.Text;
                congvan.soCongVan = soCV.Text;
                congvan.tieuDe = tieudecv.Text;
                congvan.trichNoiDung = trichnd.Text;
                congvan.ngayTao = ngaytao.Value;
                congvan.ngayCapNhat = ngaycapnhat.Value;
                congvan.trangThai = trangthai.Text;
                congvan.nguoiTao = nguoitao.Text;
                congvan.nguoiXuLy = nguoixuli.Text;
                congvan.nguoiPheDuyet = nguoipd.Text;
                congvan.mucDoKhanCap = mucdokc.Text;
                congvan.noiNhan = noinhan.Text;

                // Kiểm tra mã công văn không được trùng lặp
                var existingCV = db.CONGVANs.FirstOrDefault(cv => cv.maCV == congvan.maCV);
                if (existingCV != null)
                {
                    MessageBox.Show("Mã công văn đã tồn tại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm công văn vào cơ sở dữ liệu
                db.CONGVANs.InsertOnSubmit(congvan);
                db.SubmitChanges();

                // Reload lại dữ liệu trên DataGridView
                loadCongVanDi();

                // Thông báo thành công
                MessageBox.Show("Thêm công văn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo
                MessageBox.Show("Đã xảy ra lỗi khi thêm công văn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();

            // Hiển thị Form TrangChủ
            frm.Show();

            // Đóng Form hiện tại
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa từ TextBox
            string tuKhoa = TimKiem.Text.Trim();

            try
            {
                // Tìm công văn theo mã hoặc tiêu đề
                var query = from cv in db.CONGVANs
                            where cv.maCV.Contains(tuKhoa) || cv.tieuDe.Contains(tuKhoa)
                            select cv;

                // Hiển thị kết quả tìm kiếm
                LCV.DataSource = query.ToList();

                // Nếu không có kết quả
                if (!query.Any())
                {
                    MessageBox.Show("Không tìm thấy công văn phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã công văn từ giao diện
                string maCongVan = maCV.Text;

                // Tìm công văn trong cơ sở dữ liệu
                var congvan = db.CONGVANs.FirstOrDefault(cv => cv.maCV == maCongVan);
                if (congvan == null)
                {
                    MessageBox.Show("Không tìm thấy công văn cần sửa. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật giá trị từ giao diện vào đối tượng
                congvan.maCQ = maCQ.Text;
                congvan.maPB = maPB.Text;
                congvan.maND = maND.Text;
                congvan.maLoaiCV = maLoaiCV.Text;
                congvan.soCongVan = soCV.Text;
                congvan.tieuDe = tieudecv.Text;
                congvan.trichNoiDung = trichnd.Text;
                congvan.ngayTao = ngaytao.Value;
                congvan.ngayCapNhat = ngaycapnhat.Value;
                congvan.trangThai = trangthai.Text;
                congvan.nguoiTao = nguoitao.Text;
                congvan.nguoiXuLy = nguoixuli.Text;
                congvan.nguoiPheDuyet = nguoipd.Text;
                congvan.mucDoKhanCap = mucdokc.Text;
                congvan.noiNhan = noinhan.Text;

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                // Reload lại dữ liệu trên DataGridView
                loadCongVanDi();

                // Thông báo thành công
                MessageBox.Show("Cập nhật công văn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo
                MessageBox.Show("Đã xảy ra lỗi khi sửa công văn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã công văn từ giao diện
                string maCongVan = maCV.Text;

                // Tìm công văn trong cơ sở dữ liệu
                var congvan = db.CONGVANs.FirstOrDefault(cv => cv.maCV == maCongVan);
                if (congvan == null)
                {
                    MessageBox.Show("Không tìm thấy công văn cần xóa. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa công văn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa công văn khỏi cơ sở dữ liệu
                    db.CONGVANs.DeleteOnSubmit(congvan);
                    db.SubmitChanges();

                    // Reload lại dữ liệu trên DataGridView
                    loadCongVanDi();

                    // Thông báo thành công
                    MessageBox.Show("Xóa công văn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo
                MessageBox.Show("Đã xảy ra lỗi khi xóa công văn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }    

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Gọi lại hàm load toàn bộ dữ liệu công văn
                loadCongVanDi();

                // Xóa các ô nhập liệu trên giao diện
                ClearInputs();

                // Thông báo (nếu cần)
                MessageBox.Show("Dữ liệu đã được load lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Đã xảy ra lỗi khi load lại dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xóa các ô nhập liệu
        private void ClearInputs()
        {
            maCV.Text = "";
            maCQ.Text = "";
            maPB.Text = "";
            maND.Text = "";
            maLoaiCV.Text = "";
            soCV.Text = "";
            tieudecv.Text = "";
            trichnd.Text = "";
            ngaytao.Value = DateTime.Now;
            ngaycapnhat.Value = DateTime.Now;
            trangthai.Text = "";
            nguoitao.Text = "";
            nguoixuli.Text = "";
            nguoipd.Text = "";
            mucdokc.Text = "";
            noinhan.Text = "";
        }
    }
}
