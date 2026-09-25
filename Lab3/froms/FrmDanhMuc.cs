using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace QuanLyKhachSan
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvKhuVuc.DataSource = Db.Query("SELECT MaKhuVuc AS \"Mã Khu\", TenKhuVuc AS \"Tên Khu Vực\" FROM KhuVuc");
            dgvDichVu.DataSource = Db.Query("SELECT MaDV AS \"Mã DV\", TenDV AS \"Tên Dịch Vụ\", DonViTinh AS \"ĐVT\", DonGia AS \"Đơn Giá\" FROM DichVu");
            dgvLoaiTN.DataSource = Db.Query("SELECT MaLoaiTN AS \"Mã Loại\", TenLoaiTN AS \"Tên Loại Tiện Nghi\" FROM LoaiTienNghi");
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO KhuVuc(MaKhuVuc, TenKhuVuc) VALUES(@Ma, @Ten)";
            int result = Db.Execute(sql, new NpgsqlParameter("@Ma", txtMaKhu.Text), new NpgsqlParameter("@Ten", txtTenKhu.Text));
            if (result > 0) { MessageBox.Show("Thêm khu vực thành công!"); LoadData(); }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO DichVu(MaDV, TenDV, DonViTinh, DonGia) VALUES(@Ma, @Ten, @DVT, @Gia)";
            NpgsqlParameter[] p = {
                new NpgsqlParameter("@Ma", txtMaDV.Text),
                new NpgsqlParameter("@Ten", txtTenDV.Text),
                new NpgsqlParameter("@DVT", txtDVT.Text),
                new NpgsqlParameter("@Gia", Convert.ToDecimal(txtDonGia.Text))
            };
            if (Db.Execute(sql, p) > 0) { MessageBox.Show("Thêm dịch vụ thành công!"); LoadData(); }
        }
    }
}