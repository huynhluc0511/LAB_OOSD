using System;
using System.Windows.Forms;

namespace QuanLyBenhAn.Forms
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
            frm.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();
        }

        private void btnPhieuKham_Click(object sender, EventArgs e)
        {
            FrmPhieuKham frm = new FrmPhieuKham();
            frm.ShowDialog();
        }

        private void btnHenKham_Click(object sender, EventArgs e)
        {
            FrmHenKham frm = new FrmHenKham();
            frm.ShowDialog();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FrmTraCuu frm = new FrmTraCuu();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
