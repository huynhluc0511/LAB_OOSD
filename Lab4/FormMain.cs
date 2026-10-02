using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.eshop
{
    public partial class FormMain : Form
    {
        // Biến lưu giữ Form con hiện tại đang mở trong panelContent
        private Form currentChildForm = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Cập nhật thông tin ban đầu khi tải Form
            lblStatusUser.Text = "Người dùng: Admin / Khách hàng";
            timerClock.Start();

            // Mặc định mở FormSP (Quản lý / Xem sản phẩm) khi vừa vào chương trình
            OpenChildForm(new FormSP());
        }

        /// <summary>
        /// Hàm dùng để nhúng Form con trực tiếp vào panelContent
        /// </summary>
        /// <param name="childForm">Instance của Form con cần hiển thị</param>
        private void OpenChildForm(Form childForm)
        {
            // Nếu đã có Form con đang mở thì đóng lại
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblHeaderTitle.Text = childForm.Text; // Cập nhật tiêu đề trên thanh Header
        }

        #region --- SỰ KIỆN ĐIỀU HƯỚNG SỬ DỤNG BUTTON / MENU ---

        // Mở Form Sản phẩm
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            OpenChildForm(new FormSP());
        }

        // Mở Giỏ hàng (đang phát triển hoặc tạo mới)
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            MessageBox.Show("Chức năng Giỏ hàng đang được kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mở Đơn hàng
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            MessageBox.Show("Chức năng Quản lý đơn hàng đang phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Đăng xuất / Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Hiệu ứng đổi màu nút khi chọn
        private void HighlightButton(object senderBtn)
        {
            if (senderBtn is Button btn)
            {
                foreach (Control ctrl in panelSidebar.Controls)
                {
                    if (ctrl is Button b)
                    {
                        b.BackColor = Color.FromArgb(35, 40, 45);
                        b.ForeColor = Color.White;
                    }
                }
                btn.BackColor = Color.FromArgb(0, 122, 204);
                btn.ForeColor = Color.White;
            }
        }

        // Cập nhật đồng hồ trên thanh trạng thái
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #endregion
    }
}