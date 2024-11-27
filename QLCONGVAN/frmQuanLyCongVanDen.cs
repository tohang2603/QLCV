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
    public partial class frmQuanLyCongVanDen : Form
    {
        QLCVDataContext db = new QLCVDataContext();
        Table<frmQuanLyCongVanDi> qlcvs;
        public frmQuanLyCongVanDen()
        {
            InitializeComponent();
        }
        public void loadCongVanDen()
        {
            //Nguồn dữ liệu
            IEnumerable<CONGVAN> cvs = db.CONGVANs;
            try
            {
                // Lọc công văn đến (LCV01) và chỉ lấy các công văn có maCQ không NULL
                var congVanDen = db.CONGVANs
                                   .Where(cv => cv.maLoaiCV == "LCV01" && cv.maCQ != null)
                                   .ToList();

                // Gán dữ liệu vào DataGridView
                LCV.DataSource = congVanDen;

                // Hiển thị thông báo về số lượng công văn được lọc
                MessageBox.Show("Số công văn LCV01: " + congVanDen.Count, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Lỗi khi tải công văn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmQuanLyCongVanDen_Load(object sender, EventArgs e)
        {
            //load lại dữ liệu 
            loadCongVanDen();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();

            // Hiển thị Form TrangChủ
            frm.Show();

            // Đóng Form hiện tại
            this.Close();
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

                // Kiểm tra loại công văn và giá trị maCQ
                if (congvan.maLoaiCV == "LCV01" && string.IsNullOrEmpty(congvan.maCQ))
                {
                    MessageBox.Show("Công văn loại LCV01 yêu cầu mã cơ quan không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                loadCongVanDen();

                // Thông báo thành công
                MessageBox.Show("Thêm công văn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo
                MessageBox.Show("Đã xảy ra lỗi khi thêm công văn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã công văn từ giao diện
                string maCongVan = maCV.Text.Trim();

                if (string.IsNullOrEmpty(maCongVan))
                {
                    MessageBox.Show("Nhập mã công văn cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm công văn trong cơ sở dữ liệu
                var congvan = db.CONGVANs.FirstOrDefault(cv => cv.maCV == maCongVan);

                if (congvan == null)
                {
                    MessageBox.Show("Không tìm thấy công văn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật giá trị từ giao diện vào đối tượng
                congvan.maCQ = maCQ.Text.Trim();
                congvan.maPB = maPB.Text.Trim();
                congvan.maND = maND.Text.Trim();
                congvan.maLoaiCV = maLoaiCV.Text.Trim();
                congvan.soCongVan = soCV.Text.Trim();
                congvan.tieuDe = tieudecv.Text.Trim();
                congvan.trichNoiDung = trichnd.Text.Trim();
                congvan.ngayTao = ngaytao.Value;
                congvan.ngayCapNhat = DateTime.Now; // Tự động cập nhật thời gian hiện tại
                congvan.trangThai = trangthai.Text.Trim();
                congvan.nguoiTao = nguoitao.Text.Trim();
                congvan.nguoiXuLy = nguoixuli.Text.Trim();
                congvan.nguoiPheDuyet = nguoipd.Text.Trim();
                congvan.mucDoKhanCap = mucdokc.Text.Trim();
                congvan.noiNhan = noinhan.Text.Trim();

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                // Reload lại dữ liệu trên DataGridView
                loadCongVanDen();

                // Thông báo thành công
                MessageBox.Show("Cập nhật công văn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật công văn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    loadCongVanDen();

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

            try
            {
                // Gọi lại hàm load toàn bộ dữ liệu công văn
                loadCongVanDen();

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
