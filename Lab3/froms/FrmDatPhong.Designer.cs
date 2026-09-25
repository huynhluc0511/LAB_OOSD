using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    partial class FrmDatPhong
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

        private void InitializeComponent()
        {
            this.lblNav = new System.Windows.Forms.Label();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.txtKhach = new System.Windows.Forms.TextBox();
            this.lblKenhDat = new System.Windows.Forms.Label();
            this.txtKenhDat = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();

            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.dgvPhongChon = new System.Windows.Forms.DataGridView();
            this.colPhongChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnLapPhieuDat = new System.Windows.Forms.Button();

            this.lblTitlePhieuDat = new System.Windows.Forms.Label();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.colPhieuSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTraDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.SuspendLayout();

            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.Location = new System.Drawing.Point(20, 15);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(320, 16);
            this.lblNav.TabIndex = 0;
            this.lblNav.Text = "[Khách hàng]  [Đặt phòng]  [Nhận phòng / Người lưu trú]";

            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(20, 50);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(83, 16);
            this.lblSoPhieu.Text = "Số phiếu đặt:";

            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(105, 47);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 22);
            this.txtSoPhieu.TabIndex = 1;

            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(220, 50);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(44, 16);
            this.lblKhach.Text = "Khách:";

            // 
            // txtKhach
            // 
            this.txtKhach.Location = new System.Drawing.Point(270, 47);
            this.txtKhach.Name = "txtKhach";
            this.txtKhach.Size = new System.Drawing.Size(150, 22);
            this.txtKhach.TabIndex = 2;

            // 
            // lblKenhDat
            // 
            this.lblKenhDat.AutoSize = true;
            this.lblKenhDat.Location = new System.Drawing.Point(435, 50);
            this.lblKenhDat.Name = "lblKenhDat";
            this.lblKenhDat.Size = new System.Drawing.Size(63, 16);
            this.lblKenhDat.Text = "Kênh đặt:";

            // 
            // txtKenhDat
            // 
            this.txtKenhDat.Location = new System.Drawing.Point(500, 47);
            this.txtKenhDat.Name = "txtKenhDat";
            this.txtKenhDat.Size = new System.Drawing.Size(100, 22);
            this.txtKenhDat.TabIndex = 3;

            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Location = new System.Drawing.Point(615, 50);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(62, 16);
            this.lblTienCoc.Text = "Tiền cọc:";

            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(680, 47);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(90, 22);
            this.txtTienCoc.TabIndex = 4;

            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhong,
            this.colKhu,
            this.colSucChua,
            this.colDonGia});
            this.dgvPhong.Location = new System.Drawing.Point(20, 85);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.Size = new System.Drawing.Size(360, 150);
            this.dgvPhong.TabIndex = 5;

            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colKhu.HeaderText = "Khu";
            this.colKhu.Name = "colKhu";
            this.colSucChua.HeaderText = "Sức chứa";
            this.colSucChua.Name = "colSucChua";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";

            // 
            // dgvPhongChon
            // 
            this.dgvPhongChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhongChon,
            this.colSoNguoi,
            this.colDonGiaNgay});
            this.dgvPhongChon.Location = new System.Drawing.Point(400, 85);
            this.dgvPhongChon.Name = "dgvPhongChon";
            this.dgvPhongChon.RowHeadersWidth = 30;
            this.dgvPhongChon.Size = new System.Drawing.Size(370, 150);
            this.dgvPhongChon.TabIndex = 6;

            this.colPhongChon.HeaderText = "Phòng chọn";
            this.colPhongChon.Name = "colPhongChon";
            this.colSoNguoi.HeaderText = "Số người";
            this.colSoNguoi.Name = "colSoNguoi";
            this.colDonGiaNgay.HeaderText = "Đơn giá/ngày";
            this.colDonGiaNgay.Name = "colDonGiaNgay";

            // 
            // btnLapPhieuDat
            // 
            this.btnLapPhieuDat.Location = new System.Drawing.Point(650, 245);
            this.btnLapPhieuDat.Name = "btnLapPhieuDat";
            this.btnLapPhieuDat.Size = new System.Drawing.Size(120, 30);
            this.btnLapPhieuDat.TabIndex = 7;
            this.btnLapPhieuDat.Text = "Lập phiếu đặt";
            this.btnLapPhieuDat.UseVisualStyleBackColor = true;
            this.btnLapPhieuDat.Click += new System.EventHandler(this.btnLapPhieuDat_Click);

            // 
            // lblTitlePhieuDat
            // 
            this.lblTitlePhieuDat.AutoSize = true;
            this.lblTitlePhieuDat.Location = new System.Drawing.Point(20, 280);
            this.lblTitlePhieuDat.Name = "lblTitlePhieuDat";
            this.lblTitlePhieuDat.Size = new System.Drawing.Size(108, 16);
            this.lblTitlePhieuDat.TabIndex = 8;
            this.lblTitlePhieuDat.Text = "Phiếu đặt phòng:";

            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhieuSo,
            this.colPhieuKhach,
            this.colNgayNhan,
            this.colNgayTraDuKien,
            this.colCoc,
            this.colKenh,
            this.colTrangThai});
            this.dgvPhieuDat.Location = new System.Drawing.Point(20, 305);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.RowHeadersWidth = 30;
            this.dgvPhieuDat.Size = new System.Drawing.Size(750, 150);
            this.dgvPhieuDat.TabIndex = 9;

            this.colPhieuSo.HeaderText = "Số phiếu";
            this.colPhieuSo.Name = "colPhieuSo";
            this.colPhieuKhach.HeaderText = "Khách";
            this.colPhieuKhach.Name = "colPhieuKhach";
            this.colNgayNhan.HeaderText = "Ngày nhận";
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayTraDuKien.HeaderText = "Ngày trả dự kiến";
            this.colNgayTraDuKien.Name = "colNgayTraDuKien";
            this.colCoc.HeaderText = "Cọc";
            this.colCoc.Name = "colCoc";
            this.colKenh.HeaderText = "Kênh";
            this.colKenh.Name = "colKenh";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";

            // 
            // FrmDatPhong
            // 
            this.ClientSize = new System.Drawing.Size(790, 475);
            this.Controls.Add(this.dgvPhieuDat);
            this.Controls.Add(this.lblTitlePhieuDat);
            this.Controls.Add(this.btnLapPhieuDat);
            this.Controls.Add(this.dgvPhongChon);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.lblTienCoc);
            this.Controls.Add(this.txtKenhDat);
            this.Controls.Add(this.lblKenhDat);
            this.Controls.Add(this.txtKhach);
            this.Controls.Add(this.lblKhach);
            this.Controls.Add(this.txtSoPhieu);
            this.Controls.Add(this.lblSoPhieu);
            this.Controls.Add(this.lblNav);
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.TextBox txtKhach;
        private System.Windows.Forms.Label lblKenhDat;
        private System.Windows.Forms.TextBox txtKenhDat;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;

        private System.Windows.Forms.DataGridView dgvPhongChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNgay;

        private System.Windows.Forms.Button btnLapPhieuDat;

        private System.Windows.Forms.Label lblTitlePhieuDat;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTraDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}