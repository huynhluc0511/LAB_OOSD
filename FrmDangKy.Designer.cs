namespace QuanLyBenhAn.Forms
{
    partial class FrmDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNav = new System.Windows.Forms.Label();
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblLePhi = new System.Windows.Forms.Label();
            this.txtLePhi = new System.Windows.Forms.TextBox();
            this.lblHetHan = new System.Windows.Forms.Label();
            this.txtHetHan = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTitleDS = new System.Windows.Forms.Label();
            this.dgvHoSo = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).BeginInit();
            this.SuspendLayout();

            // lblNav
            this.lblNav.Name = "lblNav";
            this.lblNav.Location = new System.Drawing.Point(25, 15);
            this.lblNav.TabIndex = 0;
            this.lblNav.AutoSize = true;
            this.lblNav.Text = "[Bệnh nhân]  [Đăng ký khám bệnh]  [Hồ sơ bệnh án]";
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNav.ForeColor = System.Drawing.Color.Navy;

            // lblMaHoSo
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Location = new System.Drawing.Point(25, 55);
            this.lblMaHoSo.TabIndex = 1;
            this.lblMaHoSo.AutoSize = true;
            this.lblMaHoSo.Text = "Mã hồ sơ:";

            // txtMaHoSo
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Location = new System.Drawing.Point(115, 52);
            this.txtMaHoSo.Size = new System.Drawing.Size(120, 22);
            this.txtMaHoSo.TabIndex = 2;
            this.txtMaHoSo.ReadOnly = true;

            // lblHoTen
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Location = new System.Drawing.Point(260, 55);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(315, 52);
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 4;

            // lblNgaySinh
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Location = new System.Drawing.Point(540, 55);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Location = new System.Drawing.Point(620, 52);
            this.dtpNgaySinh.Size = new System.Drawing.Size(120, 22);
            this.dtpNgaySinh.TabIndex = 6;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblDienThoai
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Location = new System.Drawing.Point(25, 91);
            this.lblDienThoai.TabIndex = 7;
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Text = "Điện thoại:";

            // txtDienThoai
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Location = new System.Drawing.Point(115, 88);
            this.txtDienThoai.Size = new System.Drawing.Size(120, 22);
            this.txtDienThoai.TabIndex = 8;

            // lblDiaChi
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Location = new System.Drawing.Point(260, 91);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Text = "Địa chỉ:";

            // txtDiaChi
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Location = new System.Drawing.Point(315, 88);
            this.txtDiaChi.Size = new System.Drawing.Size(425, 22);
            this.txtDiaChi.TabIndex = 10;

            // lblLePhi
            this.lblLePhi.Name = "lblLePhi";
            this.lblLePhi.Location = new System.Drawing.Point(25, 127);
            this.lblLePhi.TabIndex = 11;
            this.lblLePhi.AutoSize = true;
            this.lblLePhi.Text = "Lệ phí/năm:";

            // txtLePhi
            this.txtLePhi.Name = "txtLePhi";
            this.txtLePhi.Location = new System.Drawing.Point(115, 124);
            this.txtLePhi.Size = new System.Drawing.Size(120, 22);
            this.txtLePhi.TabIndex = 12;
            this.txtLePhi.Text = "200000";

            // lblHetHan
            this.lblHetHan.Name = "lblHetHan";
            this.lblHetHan.Location = new System.Drawing.Point(260, 127);
            this.lblHetHan.TabIndex = 13;
            this.lblHetHan.AutoSize = true;
            this.lblHetHan.Text = "Hạn hồ sơ:";

            // txtHetHan
            this.txtHetHan.Name = "txtHetHan";
            this.txtHetHan.Location = new System.Drawing.Point(315, 124);
            this.txtHetHan.Size = new System.Drawing.Size(120, 22);
            this.txtHetHan.TabIndex = 14;
            this.txtHetHan.ReadOnly = true;

            // picAnh
            this.picAnh.Name = "picAnh";
            this.picAnh.Location = new System.Drawing.Point(775, 45);
            this.picAnh.Size = new System.Drawing.Size(120, 160);
            this.picAnh.TabIndex = 15;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // btnChonAnh
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Location = new System.Drawing.Point(775, 212);
            this.btnChonAnh.Size = new System.Drawing.Size(120, 28);
            this.btnChonAnh.TabIndex = 16;
            this.btnChonAnh.Text = "Chọn ảnh 3x4";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // btnDangKy
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Location = new System.Drawing.Point(25, 170);
            this.btnDangKy.Size = new System.Drawing.Size(140, 32);
            this.btnDangKy.TabIndex = 17;
            this.btnDangKy.Text = "Đăng ký mới";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // btnGiaHan
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Location = new System.Drawing.Point(175, 170);
            this.btnGiaHan.Size = new System.Drawing.Size(140, 32);
            this.btnGiaHan.TabIndex = 18;
            this.btnGiaHan.Text = "Gia hạn 1 năm";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);

            // btnCapNhat
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Location = new System.Drawing.Point(325, 170);
            this.btnCapNhat.Size = new System.Drawing.Size(150, 32);
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // btnLamMoi
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(485, 170);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // lblTitleDS
            this.lblTitleDS.Name = "lblTitleDS";
            this.lblTitleDS.Location = new System.Drawing.Point(25, 255);
            this.lblTitleDS.TabIndex = 21;
            this.lblTitleDS.AutoSize = true;
            this.lblTitleDS.Text = "Danh sách hồ sơ bệnh án (nhấp vào dòng để xem / gia hạn / cập nhật):";

            // dgvHoSo
            this.dgvHoSo.Name = "dgvHoSo";
            this.dgvHoSo.Location = new System.Drawing.Point(28, 280);
            this.dgvHoSo.Size = new System.Drawing.Size(867, 300);
            this.dgvHoSo.TabIndex = 22;
            this.dgvHoSo.AllowUserToAddRows = false;
            this.dgvHoSo.AllowUserToDeleteRows = false;
            this.dgvHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoSo.ReadOnly = true;
            this.dgvHoSo.RowHeadersWidth = 51;
            this.dgvHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoSo_CellClick);

            // FrmDangKy
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.lblMaHoSo);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblLePhi);
            this.Controls.Add(this.txtLePhi);
            this.Controls.Add(this.lblHetHan);
            this.Controls.Add(this.txtHetHan);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTitleDS);
            this.Controls.Add(this.dgvHoSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khám bệnh - Hồ sơ bệnh án";
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblLePhi;
        private System.Windows.Forms.TextBox txtLePhi;
        private System.Windows.Forms.Label lblHetHan;
        private System.Windows.Forms.TextBox txtHetHan;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTitleDS;
        private System.Windows.Forms.DataGridView dgvHoSo;
    }
}
