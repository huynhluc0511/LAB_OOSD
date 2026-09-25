using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách phòng trống hiển thị lên bảng bên trái
                string sqlPhong = "SELECT * FROM \"Phong\";";
                DataTable dtPhong = Db.Query(sqlPhong);
                if (dtPhong != null && dtPhong.Rows.Count > 0)
                {
                    dgvPhong.DataSource = dtPhong;
                }

                // Lấy danh sách phiếu đặt phòng hiển thị ở bảng dưới
                string sqlPhieu = "SELECT * FROM \"PhieuDatPhong\";";
                DataTable dtPhieu = Db.Query(sqlPhieu);
                if (dtPhieu != null && dtPhieu.Rows.Count > 0)
                {
                    dgvPhieuDat.DataSource = dtPhieu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLapPhieuDat_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(txtSoPhieu.Text) || string.IsNullOrWhiteSpace(txtKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số phiếu đặt và Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện ghi nhận phiếu đặt phòng vào CSDL PostgreSQL
            string sql = $"INSERT INTO \"PhieuDatPhong\" (\"SoPhieuDat\", \"TenKhach\", \"KenhDat\", \"TienCoc\") " +
                         $"VALUES ('{txtSoPhieu.Text}', '{txtKhach.Text}', '{txtKenhDat.Text}', '{txtTienCoc.Text}');";

            int rows = Db.Execute(sql);
            if (rows > 0)
            {
                MessageBox.Show("Lập phiếu đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại danh sách phiếu
            }
        }
    }
}