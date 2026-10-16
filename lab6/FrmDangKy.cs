using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBenhAn.Forms
{
    public partial class FrmDangKy : Form
    {
        private byte[] anhBytes = null;   // ảnh 3x4 của bệnh nhân
        private bool dangSua = false;     // true khi đang chọn 1 hồ sơ đã có trong danh sách

        public FrmDangKy()
        {
            InitializeComponent();
            this.Load += FrmDangKy_Load;
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            LoadData();
            LamMoiForm();
        }

        // Tạo mã hồ sơ mới: HS0001, HS0002, ...
        private string TaoMaHoSo()
        {
            DataTable dt = Db.GetData("SELECT ISNULL(MAX(CAST(SUBSTRING(MaHoSo, 3, 10) AS INT)), 0) + 1 FROM BenhNhan");
            int so = 1;
            if (dt != null && dt.Rows.Count > 0) so = Convert.ToInt32(dt.Rows[0][0]);
            return "HS" + so.ToString("D4");
        }

        private void LamMoiForm()
        {
            dangSua = false;
            txtMaHoSo.Text = TaoMaHoSo();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtLePhi.Text = "200000";
            txtHetHan.Clear();
            dtpNgaySinh.Value = new DateTime(1990, 1, 1);
            anhBytes = null;
            HienAnh();
            txtHoTen.Focus();
        }

        // Tải danh sách hồ sơ lên dgvHoSo
        private void LoadData()
        {
            string query = @"SELECT b.MaHoSo AS [Mã hồ sơ],
                                    b.HoTen AS [Họ tên],
                                    CONVERT(VARCHAR(10), b.NgaySinh, 103) AS [Ngày sinh],
                                    b.DienThoai AS [Điện thoại],
                                    b.DiaChi AS [Địa chỉ],
                                    CONVERT(VARCHAR(10), h.HetHan, 103) AS [Hạn hồ sơ],
                                    CASE WHEN h.HetHan >= CAST(GETDATE() AS DATE) THEN N'Còn hạn' ELSE N'Hết hạn' END AS [Trạng thái]
                             FROM BenhNhan b
                             OUTER APPLY (SELECT MAX(d.NgayHetHan) AS HetHan FROM DangKy d WHERE d.MaHoSo = b.MaHoSo) h
                             ORDER BY b.MaHoSo";
            DataTable dt = Db.GetData(query);
            if (dt != null) dgvHoSo.DataSource = dt;
        }

        private void HienAnh()
        {
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }
            if (anhBytes != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(anhBytes))
                    using (Image img = Image.FromStream(ms))
                    {
                        picAnh.Image = new Bitmap(img);
                    }
                }
                catch (Exception)
                {
                    picAnh.Image = null;
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp 3x4";
                ofd.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    if (fi.Length > 2 * 1024 * 1024)
                    {
                        MessageBox.Show("Ảnh quá lớn, vui lòng chọn ảnh nhỏ hơn 2MB!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    anhBytes = File.ReadAllBytes(ofd.FileName);
                    HienAnh();
                }
            }
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraNhap(out decimal lePhi)
        {
            lePhi = 0;
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại liên lạc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }
            if (dtpNgaySinh.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string s = txtLePhi.Text.Trim().Replace(".", "").Replace(",", "");
            if (!decimal.TryParse(s, out lePhi) || lePhi <= 0)
            {
                MessageBox.Show("Lệ phí phải là số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLePhi.Focus();
                return false;
            }
            return true;
        }

        private SqlParameter ThamSoAnh()
        {
            SqlParameter p = new SqlParameter("@anh", SqlDbType.VarBinary, -1);
            p.Value = anhBytes == null ? (object)DBNull.Value : anhBytes;
            return p;
        }

        private SqlParameter ThamSoNgaySinh()
        {
            SqlParameter p = new SqlParameter("@ns", SqlDbType.Date);
            p.Value = dtpNgaySinh.Value.Date;
            return p;
        }

        private SqlParameter ThamSoLePhi(decimal lePhi)
        {
            SqlParameter p = new SqlParameter("@lephi", SqlDbType.Decimal);
            p.Precision = 18;
            p.Scale = 0;
            p.Value = lePhi;
            return p;
        }

        // Đăng ký bệnh nhân mới: tạo hồ sơ + đóng lệ phí 1 năm
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (dangSua)
            {
                MessageBox.Show("Hồ sơ này đã tồn tại. Hãy dùng 'Gia hạn' hoặc 'Cập nhật thông tin',\nhoặc bấm 'Làm mới' để đăng ký bệnh nhân mới.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal lePhi;
            if (!KiemTraNhap(out lePhi)) return;

            string maHoSo = TaoMaHoSo();
            string sql = @"SET XACT_ABORT ON; BEGIN TRAN;
                           INSERT INTO BenhNhan(MaHoSo, HoTen, DiaChi, NgaySinh, DienThoai, Anh)
                                  VALUES (@ma, @ten, @dc, @ns, @dt, @anh);
                           INSERT INTO DangKy(MaHoSo, NgayDangKy, LePhi, NgayHetHan)
                                  VALUES (@ma, CAST(GETDATE() AS DATE), @lephi, DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)));
                           COMMIT;";

            int result = Db.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maHoSo),
                new SqlParameter("@ten", txtHoTen.Text.Trim()),
                new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                ThamSoNgaySinh(),
                new SqlParameter("@dt", txtDienThoai.Text.Trim()),
                ThamSoAnh(),
                ThamSoLePhi(lePhi));

            if (result > 0)
            {
                MessageBox.Show("Đăng ký thành công!\nMã hồ sơ của bệnh nhân: " + maHoSo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LamMoiForm();
            }
        }

        // Gia hạn thêm 1 năm (đóng lệ phí hằng năm)
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần gia hạn trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal lePhi;
            if (!KiemTraNhap(out lePhi)) return;

            string sql = @"DECLARE @hh DATE = (SELECT MAX(NgayHetHan) FROM DangKy WHERE MaHoSo = @ma);
                           DECLARE @homNay DATE = CAST(GETDATE() AS DATE);
                           INSERT INTO DangKy(MaHoSo, NgayDangKy, LePhi, NgayHetHan)
                           VALUES (@ma, @homNay, @lephi,
                                   DATEADD(YEAR, 1, CASE WHEN @hh IS NOT NULL AND @hh >= @homNay THEN @hh ELSE @homNay END));";

            int result = Db.ExecuteNonQuery(sql, new SqlParameter("@ma", txtMaHoSo.Text), ThamSoLePhi(lePhi));
            if (result > 0)
            {
                MessageBox.Show("Gia hạn hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                CapNhatHanHoSo(txtMaHoSo.Text);
            }
        }

        // Cập nhật thông tin phiếu đăng ký (họ tên, địa chỉ, ngày sinh, điện thoại, ảnh)
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần cập nhật trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal lePhi;
            if (!KiemTraNhap(out lePhi)) return;

            string sql = @"UPDATE BenhNhan SET HoTen = @ten, DiaChi = @dc, NgaySinh = @ns, DienThoai = @dt, Anh = @anh
                           WHERE MaHoSo = @ma";

            int result = Db.ExecuteNonQuery(sql,
                new SqlParameter("@ma", txtMaHoSo.Text),
                new SqlParameter("@ten", txtHoTen.Text.Trim()),
                new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                ThamSoNgaySinh(),
                new SqlParameter("@dt", txtDienThoai.Text.Trim()),
                ThamSoAnh());

            if (result > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void CapNhatHanHoSo(string ma)
        {
            object h = Db.ExecuteScalar("SELECT MAX(NgayHetHan) FROM DangKy WHERE MaHoSo = @ma", new SqlParameter("@ma", ma));
            txtHetHan.Text = (h == null || h == DBNull.Value) ? "" : Convert.ToDateTime(h).ToString("dd/MM/yyyy");
        }

        // Bấm chọn 1 hồ sơ trong danh sách để xem/sửa/gia hạn
        private void dgvHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ma = dgvHoSo.Rows[e.RowIndex].Cells["Mã hồ sơ"].Value.ToString();
            DataTable dt = Db.GetData("SELECT HoTen, DiaChi, NgaySinh, DienThoai, Anh FROM BenhNhan WHERE MaHoSo = @ma",
                new SqlParameter("@ma", ma));
            if (dt == null || dt.Rows.Count == 0) return;

            DataRow r = dt.Rows[0];
            txtMaHoSo.Text = ma;
            txtHoTen.Text = r["HoTen"].ToString();
            txtDiaChi.Text = r["DiaChi"].ToString();
            txtDienThoai.Text = r["DienThoai"].ToString();
            dtpNgaySinh.Value = r["NgaySinh"] == DBNull.Value ? new DateTime(1990, 1, 1) : Convert.ToDateTime(r["NgaySinh"]);
            anhBytes = r["Anh"] == DBNull.Value ? null : (byte[])r["Anh"];
            HienAnh();
            CapNhatHanHoSo(ma);
            dangSua = true;
        }
    }
}
