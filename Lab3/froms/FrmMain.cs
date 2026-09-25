
using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.Show();// new FrmDanhMuc().ShowDialog();
        }

        private void btnPhongTienNghi_Click(object sender, EventArgs e)
        {
            FrmPhongTienNghi frm = new FrmPhongTienNghi();
            frm.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FrmDatPhong frm = new FrmDatPhong();
            frm.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            // new FrmDichVu().ShowDialog();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát hệ thống?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}