using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql; // Thư viện kết nối PostgreSQL

namespace WindowsFormsApp1.eshop
{
    public partial class FormSP : Form
    {
        // Chuỗi kết nối tới PostgreSQL
        private string connectionString = "Host=localhost;Port=5432;Database=shop;Username=postgres;Password=123;";

        public FormSP()
        {
            InitializeComponent();
        }

        private void FormSP_Load(object sender, EventArgs e)
        {
            // --- 1. MỞ KHÓA TẤT CẢ CÁC Ô NHẬP LIỆU Bị KHÓA / NỀN XÁM ---
            txtMaSP.ReadOnly = false;
            txtTenSP.ReadOnly = false;
            txtTenNhaSX.ReadOnly = false;

            // Mở khóa ô Giá bán
            numGiaBan.Enabled = true;
            numGiaBan.ReadOnly = false;
            numGiaBan.Maximum = 1000000000; // Đặt giới hạn lên 1 tỷ để nhập thoải mái

            // Mở khóa ô Số lượng tồn
            numSoLuongTon.Enabled = true;
            numSoLuongTon.ReadOnly = false;
            numSoLuongTon.Maximum = 1000000; // Đặt giới hạn tồn kho lớn

            // Mở khóa ô Số lượng mua
            numSoLuongMua.Enabled = true;
            numSoLuongMua.Maximum = 10000;

            // --- 2. TẢI DỮ LIỆU BAN ĐẦU ---
            LoadNhomSanPham();
            LoadDanhSachSanPham();
        }

        #region --- TẢI DỮ LIỆU ---

        /// <summary>
        /// Tải danh sách nhóm sản phẩm vào ComboBox
        /// </summary>
        private void LoadNhomSanPham()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT MaNhom, TenNhom FROM NhomSanPham ORDER BY TenNhom ASC";
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Thêm dòng "Tất cả nhóm" ở đầu
                        DataRow dr = dt.NewRow();
                        dr["MaNhom"] = "ALL";
                        dr["TenNhom"] = "-- Tất cả nhóm --";
                        dt.Rows.InsertAt(dr, 0);

                        cboNhomSP.DataSource = dt;
                        cboNhomSP.DisplayMember = "TenNhom";
                        cboNhomSP.ValueMember = "MaNhom";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhóm SP: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải danh sách sản phẩm lên DataGridView (Lấy đầy đủ các trường dữ liệu)
        /// </summary>
        private void LoadDanhSachSanPham(string maNhom = "ALL", string tuKhoa = "")
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        SELECT 
                            sp.MaSP AS ""Mã SP"",
                            sp.TenSP AS ""Tên Sản Phẩm"",
                            sp.MaNhom AS ""Mã Nhóm"",
                            nsp.TenNhom AS ""Nhóm SP"",
                            sp.TenNhaSX AS ""Nhà Sản Xuất"",
                            sp.GiaBan AS ""Giá Bán (VNĐ)"",
                            sp.SoLuongTon AS ""Tồn Kho"",
                            sp.TinhTrang AS ""TinhTrang"",
                            CASE WHEN sp.TinhTrang = TRUE THEN N'Còn hàng' ELSE N'Hết hàng' END AS ""Trạng Thái"",
                            sp.HinhAnh AS ""HinhAnh"",
                            sp.MoTa AS ""MoTa"",
                            sp.ThongSoKyThuat AS ""ThongSoKyThuat""
                        FROM SanPham sp
                        INNER JOIN NhomSanPham nsp ON sp.MaNhom = nsp.MaNhom
                        WHERE 1=1";

                    if (maNhom != "ALL" && !string.IsNullOrEmpty(maNhom))
                    {
                        sql += " AND sp.MaNhom = @MaNhom";
                    }

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        sql += " AND (sp.TenSP ILIKE @TuKhoa OR sp.MaSP ILIKE @TuKhoa)";
                    }

                    sql += " ORDER BY sp.MaSP DESC";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        if (maNhom != "ALL" && !string.IsNullOrEmpty(maNhom))
                            cmd.Parameters.AddWithValue("@MaNhom", maNhom);

                        if (!string.IsNullOrWhiteSpace(tuKhoa))
                            cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa.Trim() + "%");

                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvSanPham.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region --- SỰ KIỆN GIAO DIỆN ---

        // Lọc danh sách khi chọn Nhóm sản phẩm khác
        private void cboNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhomSP.SelectedValue != null)
            {
                string selectedGroup = cboNhomSP.SelectedValue.ToString();
                LoadDanhSachSanPham(selectedGroup, txtTimKiem.Text);
            }
        }

        // Tìm kiếm sản phẩm theo từ khóa
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string selectedGroup = cboNhomSP.SelectedValue != null ? cboNhomSP.SelectedValue.ToString() : "ALL";
            LoadDanhSachSanPham(selectedGroup, txtTimKiem.Text);
        }

        // Click chọn dòng trên DataGridView để hiển thị lên các ô thông tin chi tiết
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["Mã SP"].Value?.ToString();
                txtTenSP.Text = row.Cells["Tên Sản Phẩm"].Value?.ToString();
                txtTenNhaSX.Text = row.Cells["Nhà Sản Xuất"].Value?.ToString();

                // Gán giá trị cho Giá bán & Tồn kho
                if (row.Cells["Giá Bán (VNĐ)"].Value != DBNull.Value)
                    numGiaBan.Value = Convert.ToDecimal(row.Cells["Giá Bán (VNĐ)"].Value);

                if (row.Cells["Tồn Kho"].Value != DBNull.Value)
                    numSoLuongTon.Value = Convert.ToInt32(row.Cells["Tồn Kho"].Value);

                // Tự động đổ dữ liệu vào các control bổ sung (nếu có trên giao diện)
                if (Controls.Find("txtMoTa", true).Length > 0)
                    Controls.Find("txtMoTa", true)[0].Text = row.Cells["MoTa"].Value?.ToString();

                if (Controls.Find("txtThongSo", true).Length > 0)
                    Controls.Find("txtThongSo", true)[0].Text = row.Cells["ThongSoKyThuat"].Value?.ToString();

                if (Controls.Find("picHinhAnh", true).Length > 0)
                {
                    PictureBox pic = Controls.Find("picHinhAnh", true)[0] as PictureBox;
                    string imgPath = row.Cells["HinhAnh"].Value?.ToString();
                    if (pic != null && !string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                        pic.ImageLocation = imgPath;
                    else if (pic != null)
                        pic.Image = null;
                }
            }
        }

        // Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtTenNhaSX.Clear();
            txtTimKiem.Clear();
            numGiaBan.Value = 0;
            numSoLuongTon.Value = 0;
            numSoLuongMua.Value = 0;
            cboNhomSP.SelectedIndex = 0;
            LoadDanhSachSanPham();
        }

        // Nút Thêm vào giỏ hàng
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongMua = (int)numSoLuongMua.Value;
            if (soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soLuongMua > numSoLuongTon.Value)
            {
                MessageBox.Show("Số lượng tồn kho không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Đã thêm {soLuongMua} x [{txtTenSP.Text}] vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}