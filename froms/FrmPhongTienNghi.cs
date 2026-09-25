using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmPhongTienNghi : Form
    {
        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Lấy danh sách phòng hiển thị lên DataGridView
            string sql = "SELECT * FROM \"Phong\";";
            DataTable dt = Db.Query(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvPhong.DataSource = dt;
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtPhieuLapDat.Text) ||
                string.IsNullOrWhiteSpace(txtTienNghi.Text) ||
                string.IsNullOrWhiteSpace(txtPhongBottom.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phiếu, Tiện nghi và Số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh thêm phiếu lắp đặt vào CSDL
            string sql = $"INSERT INTO \"PhieuLapDat\" (\"SoPhieuLapDat\", \"MaTienNghi\", \"SoPhong\", \"TinhTrang\") " +
                         $"VALUES ('{txtPhieuLapDat.Text}', '{txtTienNghi.Text}', '{txtPhongBottom.Text}', '{txtTinhTrang.Text}');";

            int rows = Db.Execute(sql);
            if (rows > 0)
            {
                MessageBox.Show("Ghi nhận lập phiếu lắp đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}