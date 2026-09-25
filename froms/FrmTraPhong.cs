using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using QuanLyKhachSan; // Import namespace chứa lớp Db

namespace Quanlykhachsang.Forms
{
    public partial class FrmTraPhong : Form
    {
        private DataTable dtDenBu;
        private string selectedSoPhong = "";
        private string selectedMaTienNghi = "";

        public FrmTraPhong()
        {
            InitializeComponent();
            this.Load += FrmTraPhong_Load;
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            InitTableDenBu();

            txtSoPhieuDenBu.Text = "DB001";
            txtMucDo.Text = "Hư hỏng nhẹ";
            txtSoTienDenBu.Text = "500000";
            txtSoHoaDon.Text = "HD001";
            txtSoNgayTinhTien.Text = "2";
            txtHinhThuc.Text = "Thẻ";
            txtSoTienThanhToan.Text = "1200000";

            string topPhieuQuery = "SELECT \"SoPhieuDat\" FROM \"PhieuDatPhong\" ORDER BY \"NgayLap\" DESC LIMIT 1";
            DataTable dtPhieu = Db.Query(topPhieuQuery);
            if (dtPhieu != null && dtPhieu.Rows.Count > 0)
            {
                txtPhieuDangO.Text = dtPhieu.Rows[0]["SoPhieuDat"].ToString();
            }
            else
            {
                txtPhieuDangO.Text = "DP001";
            }

            LoadAllData();
        }

        private void InitTableDenBu()
        {
            dtDenBu = new DataTable();
            dtDenBu.Columns.Add("Tiện nghi đền bù", typeof(string));
            dtDenBu.Columns.Add("Mức độ", typeof(string));
            dtDenBu.Columns.Add("Số tiền", typeof(decimal));

            dgvTienNghiDenBu.DataSource = dtDenBu;
        }

        private void LoadAllData()
        {
            string soPhieu = txtPhieuDangO.Text.Trim();
            if (string.IsNullOrEmpty(soPhieu)) return;

            LoadDataPhong(soPhieu);
            LoadDataHoaDon(soPhieu);
        }

        private void txtPhieuDangO_TextChanged(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadDataPhong(string soPhieu)
        {
            string query = $@"SELECT ct.""SoPhong"" AS ""Phòng"", p.""DonGiaNgay"" AS ""Đơn giá/ngày""
                            FROM ""ChiTietDatPhong"" ct
                            JOIN ""Phong"" p ON ct.""SoPhong"" = p.""SoPhong""
                            WHERE ct.""SoPhieuDat"" = '{soPhieu}'";

            DataTable dt = Db.Query(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                dt = new DataTable();
                dt.Columns.Add("Phòng", typeof(string));
                dt.Columns.Add("Đơn giá/ngày", typeof(string));
                dt.Rows.Add("101", "500.000");
                dt.Rows.Add("102", "700.000");
            }

            dgvPhong.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                selectedSoPhong = dt.Rows[0]["Phòng"].ToString();
                LoadDataTienNghi(selectedSoPhong);
            }
            else
            {
                dgvTienNghi.DataSource = null;
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value != null)
            {
                selectedSoPhong = dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value.ToString();
                LoadDataTienNghi(selectedSoPhong);
            }
        }

        private void LoadDataTienNghi(string soPhong)
        {
            string query = $@"SELECT tn.""MaTienNghi"", ltn.""TenLoaiTN"" AS ""Tiện nghi"", ltn.""TenLoaiTN"" AS ""Loại"", tn.""TinhTrangHienTai"" AS ""Tình trạng""
                            FROM ""PhieuLapDat"" pld
                            JOIN ""TienNghi"" tn ON pld.""MaTienNghi"" = tn.""MaTienNghi""
                            JOIN ""LoaiTienNghi"" ltn ON tn.""MaLoaiTN"" = ltn.""MaLoaiTN""
                            WHERE pld.""SoPhong"" = '{soPhong}'";

            DataTable dt = Db.Query(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                dt = new DataTable();
                dt.Columns.Add("MaTienNghi", typeof(string));
                dt.Columns.Add("Tiện nghi", typeof(string));
                dt.Columns.Add("Loại", typeof(string));
                dt.Columns.Add("Tình trạng", typeof(string));

                dt.Rows.Add("TN01", "Tivi", "Điện tử", "Bình thường");
                dt.Rows.Add("TN02", "Tủ lạnh", "Điện lạnh", "Hư hỏng nhẹ");
                dt.Rows.Add("TN03", "Máy lạnh", "Điện lạnh", "Bình thường");
            }

            dgvTienNghi.DataSource = dt;
            if (dgvTienNghi.Columns["MaTienNghi"] != null)
            {
                dgvTienNghi.Columns["MaTienNghi"].Visible = false;
            }
        }

        private void dgvTienNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTienNghi.Rows[e.RowIndex].Cells["Tiện nghi"].Value != null)
            {
                if (dgvTienNghi.Columns.Contains("MaTienNghi") && dgvTienNghi.Rows[e.RowIndex].Cells["MaTienNghi"].Value != null)
                {
                    selectedMaTienNghi = dgvTienNghi.Rows[e.RowIndex].Cells["MaTienNghi"].Value.ToString();
                }

                string queryQd = $@"SELECT qd.""MucDenBu"", qd.""MucDoThietHai"" 
                                  FROM ""QuyDinhDenBu"" qd
                                  JOIN ""TienNghi"" tn ON qd.""MaLoaiTN"" = tn.""MaLoaiTN""
                                  WHERE tn.""MaTienNghi"" = '{selectedMaTienNghi}'";

                DataTable dtQd = Db.Query(queryQd);
                if (dtQd != null && dtQd.Rows.Count > 0)
                {
                    txtMucDo.Text = dtQd.Rows[0]["MucDoThietHai"].ToString();
                    txtSoTienDenBu.Text = Convert.ToDecimal(dtQd.Rows[0]["MucDenBu"]).ToString("0");
                }
            }
        }

        private void btnLapPhieuDenBu_Click(object sender, EventArgs e)
        {
            string soPhieuDat = txtPhieuDangO.Text.Trim();
            string soPhieuDB = txtSoPhieuDenBu.Text.Trim();
            string mucDo = txtMucDo.Text.Trim();
            string soTienStr = txtSoTienDenBu.Text.Trim();

            if (string.IsNullOrEmpty(soPhieuDat) || string.IsNullOrEmpty(soPhieuDB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu đền bù!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(soTienStr, out decimal soTien);
            string maNV = "NV02";

            string insertPDB = $@"INSERT INTO ""PhieuDenBu""(""SoPhieuDenBu"", ""SoPhieuDat"", ""SoPhong"", ""NgayLap"", ""MaNV"", ""TongTien"")
                                VALUES ('{soPhieuDB}', '{soPhieuDat}', '{selectedSoPhong}', NOW(), '{maNV}', {soTien})";

            Db.Execute(insertPDB);

            if (!string.IsNullOrEmpty(selectedMaTienNghi))
            {
                string insertCTDB = $@"INSERT INTO ""ChiTietPhieuDenBu""(""SoPhieuDenBu"", ""MaTienNghi"", ""MucDoThietHai"", ""SoTien"")
                                      VALUES ('{soPhieuDB}', '{selectedMaTienNghi}', '{mucDo}', {soTien})";
                Db.Execute(insertCTDB);
            }

            dtDenBu.Rows.Add(string.IsNullOrEmpty(selectedMaTienNghi) ? "Tủ lạnh" : selectedMaTienNghi, mucDo, soTien);
            MessageBox.Show("Lập phiếu đền bù thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            string soPhieuDat = txtPhieuDangO.Text.Trim();
            string soHoaDon = txtSoHoaDon.Text.Trim();
            string soNgayStr = txtSoNgayTinhTien.Text.Trim();

            if (string.IsNullOrEmpty(soPhieuDat) || string.IsNullOrEmpty(soHoaDon) || !int.TryParse(soNgayStr, out int soNgay))
            {
                MessageBox.Show("Vui lòng nhập hợp lệ Số hóa đơn và Số ngày tính tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryTienPhong = $@"SELECT SUM(p.""DonGiaNgay"" * {soNgay}) AS TienPhong
                                     FROM ""ChiTietDatPhong"" ct
                                     JOIN ""Phong"" p ON ct.""SoPhong"" = p.""SoPhong""
                                     WHERE ct.""SoPhieuDat"" = '{soPhieuDat}'";
            DataTable dtTienPhong = Db.Query(queryTienPhong);
            decimal tienPhong = 1000000;
            if (dtTienPhong != null && dtTienPhong.Rows.Count > 0 && dtTienPhong.Rows[0]["TienPhong"] != DBNull.Value)
            {
                tienPhong = Convert.ToDecimal(dtTienPhong.Rows[0]["TienPhong"]);
            }

            string queryTienDV = $@"SELECT COALESCE(SUM(ct.""ThanhTien""), 0) AS TienDV
                                  FROM ""PhieuSuDungDV"" p
                                  JOIN ""ChiTietPhieuSuDungDV"" ct ON p.""SoPhieuSDDV"" = ct.""SoPhieuSDDV""
                                  WHERE p.""SoPhieuDat"" = '{soPhieuDat}'";
            DataTable dtTienDV = Db.Query(queryTienDV);
            decimal tienDV = 200000;
            if (dtTienDV != null && dtTienDV.Rows.Count > 0 && dtTienDV.Rows[0]["TienDV"] != DBNull.Value)
            {
                tienDV = Convert.ToDecimal(dtTienDV.Rows[0]["TienDV"]);
            }

            string maNV = "NV03";
            string insertHD = $@"INSERT INTO ""HoaDon""(""SoHoaDon"", ""SoPhieuDat"", ""NgayLap"", ""MaNV"", ""SoNgayTinhTien"", ""TienPhong"", ""TienDichVu"", ""TrangThai"")
                                VALUES ('{soHoaDon}', '{soPhieuDat}', NOW(), '{maNV}', {soNgay}, {tienPhong}, {tienDV}, 'Chưa thanh toán')";

            Db.Execute(insertHD);

            MessageBox.Show("Lập hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataHoaDon(soPhieuDat);
            txtSoTienThanhToan.Text = (tienPhong + tienDV).ToString("0");
        }

        private void LoadDataHoaDon(string soPhieu)
        {
            string query = $@"SELECT ""SoHoaDon"" AS ""Hóa đơn"", 
                                   ""SoPhieuDat"" AS ""Phiếu đặt"", 
                                   ""TienPhong"" AS ""Tiền phòng"", 
                                   ""TienDichVu"" AS ""Tiền dịch vụ"", 
                                   ""TongTien"" AS ""Tổng tiền"", 
                                   ""TrangThai"" AS ""Trạng thái""
                            FROM ""HoaDon"" 
                            WHERE ""SoPhieuDat"" = '{soPhieu}'";

            DataTable dt = Db.Query(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                dt = new DataTable();
                dt.Columns.Add("Hóa đơn", typeof(string));
                dt.Columns.Add("Phiếu đặt", typeof(string));
                dt.Columns.Add("Tiền phòng", typeof(string));
                dt.Columns.Add("Tiền dịch vụ", typeof(string));
                dt.Columns.Add("Tổng tiền", typeof(string));
                dt.Columns.Add("Trạng thái", typeof(string));

                dt.Rows.Add("HD001", soPhieu, "1.000.000", "200.000", "1.200.000", "Chưa thanh toán");
            }

            dgvHoaDon.DataSource = dt;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHoaDon.Rows[e.RowIndex].Cells["Hóa đơn"].Value != null)
            {
                txtSoHoaDon.Text = dgvHoaDon.Rows[e.RowIndex].Cells["Hóa đơn"].Value.ToString();
                if (dgvHoaDon.Rows[e.RowIndex].Cells["Tổng tiền"].Value != null)
                {
                    txtSoTienThanhToan.Text = dgvHoaDon.Rows[e.RowIndex].Cells["Tổng tiền"].Value.ToString();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string soHoaDon = txtSoHoaDon.Text.Trim();
            string hinhThuc = txtHinhThuc.Text.Trim();
            string soTienStr = txtSoTienThanhToan.Text.Trim();

            if (string.IsNullOrEmpty(soHoaDon) || string.IsNullOrEmpty(hinhThuc) || !decimal.TryParse(soTienStr, out decimal soTien))
            {
                MessageBox.Show("Vui lòng chọn Hóa đơn, Hình thức và Số tiền thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maTT = "TT_" + DateTime.Now.ToString("fff");
            string insertTT = $@"INSERT INTO ""ThanhToan""(""MaThanhToan"", ""SoHoaDon"", ""NgayThanhToan"", ""HinhThuc"", ""SoTien"")
                                VALUES ('{maTT}', '{soHoaDon}', NOW(), '{hinhThuc}', {soTien})";

            Db.Execute(insertTT);

            string updateHD = $"UPDATE \"HoaDon\" SET \"TrangThai\" = 'Đã thanh toán' WHERE \"SoHoaDon\" = '{soHoaDon}'";
            Db.Execute(updateHD);

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataHoaDon(txtPhieuDangO.Text.Trim());
        }

        private void btnHoanTatTraPhong_Click(object sender, EventArgs e)
        {
            string soPhieuDat = txtPhieuDangO.Text.Trim();
            if (string.IsNullOrEmpty(soPhieuDat)) return;

            string updatePhieu = $"UPDATE \"PhieuDatPhong\" SET \"TrangThai\" = 'Đã trả', \"NgayTraThucTe\" = NOW() WHERE \"SoPhieuDat\" = '{soPhieuDat}'";
            Db.Execute(updatePhieu);

            string updatePhong = $@"UPDATE ""Phong"" 
                                   SET ""TrangThai"" = 'Trống' 
                                   WHERE ""SoPhong"" IN (SELECT ""SoPhong"" FROM ""ChiTietDatPhong"" WHERE ""SoPhieuDat"" = '{soPhieuDat}')";
            Db.Execute(updatePhong);

            MessageBox.Show("Đã hoàn tất thủ tục trả phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}