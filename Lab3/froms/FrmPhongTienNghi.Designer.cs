using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    partial class FrmPhongTienNghi
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
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtKhuVuc = new System.Windows.Forms.TextBox();
            this.lblSoNguoiToiDa = new System.Windows.Forms.Label();
            this.txtSoNguoiToiDa = new System.Windows.Forms.TextBox();
            this.lblDonGiaNgay = new System.Windows.Forms.Label();
            this.txtDonGiaNgay = new System.Windows.Forms.TextBox();

            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lblPhieuLapDat = new System.Windows.Forms.Label();
            this.txtPhieuLapDat = new System.Windows.Forms.TextBox();
            this.lblTienNghi = new System.Windows.Forms.Label();
            this.txtTienNghi = new System.Windows.Forms.TextBox();
            this.lblPhongBottom = new System.Windows.Forms.Label();
            this.txtPhongBottom = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();

            this.btnLapPhieu = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();

            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.Location = new System.Drawing.Point(20, 20);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(300, 16);
            this.lblNav.TabIndex = 0;
            this.lblNav.Text = "[Phòng]  [Tiện nghi]  [Lắp đặt / luân chuyển]";

            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(20, 55);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(68, 16);
            this.lblSoPhong.Text = "Số phòng:";

            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(95, 52);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(100, 22);
            this.txtSoPhong.TabIndex = 1;

            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Location = new System.Drawing.Point(210, 55);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(57, 16);
            this.lblKhuVuc.Text = "Khu vực:";

            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(275, 52);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(110, 22);
            this.txtKhuVuc.TabIndex = 2;

            // 
            // lblSoNguoiToiDa
            // 
            this.lblSoNguoiToiDa.AutoSize = true;
            this.lblSoNguoiToiDa.Location = new System.Drawing.Point(400, 55);
            this.lblSoNguoiToiDa.Name = "lblSoNguoiToiDa";
            this.lblSoNguoiToiDa.Size = new System.Drawing.Size(100, 16);
            this.lblSoNguoiToiDa.Text = "Số người tối đa:";

            // 
            // txtSoNguoiToiDa
            // 
            this.txtSoNguoiToiDa.Location = new System.Drawing.Point(505, 52);
            this.txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            this.txtSoNguoiToiDa.Size = new System.Drawing.Size(60, 22);
            this.txtSoNguoiToiDa.TabIndex = 3;

            // 
            // lblDonGiaNgay
            // 
            this.lblDonGiaNgay.AutoSize = true;
            this.lblDonGiaNgay.Location = new System.Drawing.Point(580, 55);
            this.lblDonGiaNgay.Name = "lblDonGiaNgay";
            this.lblDonGiaNgay.Size = new System.Drawing.Size(92, 16);
            this.lblDonGiaNgay.Text = "Đơn giá/ngày:";

            // 
            // txtDonGiaNgay
            // 
            this.txtDonGiaNgay.Location = new System.Drawing.Point(678, 52);
            this.txtDonGiaNgay.Name = "txtDonGiaNgay";
            this.txtDonGiaNgay.Size = new System.Drawing.Size(100, 22);
            this.txtDonGiaNgay.TabIndex = 4;

            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhong,
            this.colKhu,
            this.colSucChua,
            this.colDonGia,
            this.colTrangThai});
            this.dgvPhong.Location = new System.Drawing.Point(20, 95);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(758, 200);
            this.dgvPhong.TabIndex = 5;

            // colPhong
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";

            // colKhu
            this.colKhu.HeaderText = "Khu";
            this.colKhu.Name = "colKhu";

            // colSucChua
            this.colSucChua.HeaderText = "Sức chứa";
            this.colSucChua.Name = "colSucChua";

            // colDonGia
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";

            // colTrangThai
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";

            // 
            // lblPhieuLapDat
            // 
            this.lblPhieuLapDat.AutoSize = true;
            this.lblPhieuLapDat.Location = new System.Drawing.Point(20, 320);
            this.lblPhieuLapDat.Name = "lblPhieuLapDat";
            this.lblPhieuLapDat.Size = new System.Drawing.Size(90, 16);
            this.lblPhieuLapDat.Text = "Phiếu lắp đặt:";

            // 
            // txtPhieuLapDat
            // 
            this.txtPhieuLapDat.Location = new System.Drawing.Point(115, 317);
            this.txtPhieuLapDat.Name = "txtPhieuLapDat";
            this.txtPhieuLapDat.Size = new System.Drawing.Size(90, 22);
            this.txtPhieuLapDat.TabIndex = 6;

            // 
            // lblTienNghi
            // 
            this.lblTienNghi.AutoSize = true;
            this.lblTienNghi.Location = new System.Drawing.Point(220, 320);
            this.lblTienNghi.Name = "lblTienNghi";
            this.lblTienNghi.Size = new System.Drawing.Size(65, 16);
            this.lblTienNghi.Text = "Tiện nghi:";

            // 
            // txtTienNghi
            // 
            this.txtTienNghi.Location = new System.Drawing.Point(290, 317);
            this.txtTienNghi.Name = "txtTienNghi";
            this.txtTienNghi.Size = new System.Drawing.Size(80, 22);
            this.txtTienNghi.TabIndex = 7;

            // 
            // lblPhongBottom
            // 
            this.lblPhongBottom.AutoSize = true;
            this.lblPhongBottom.Location = new System.Drawing.Point(385, 320);
            this.lblPhongBottom.Name = "lblPhongBottom";
            this.lblPhongBottom.Size = new System.Drawing.Size(50, 16);
            this.lblPhongBottom.Text = "Phòng:";

            // 
            // txtPhongBottom
            // 
            this.txtPhongBottom.Location = new System.Drawing.Point(440, 317);
            this.txtPhongBottom.Name = "txtPhongBottom";
            this.txtPhongBottom.Size = new System.Drawing.Size(80, 22);
            this.txtPhongBottom.TabIndex = 8;

            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(535, 320);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(70, 16);
            this.lblTinhTrang.Text = "Tình trạng:";

            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(610, 317);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(90, 22);
            this.txtTinhTrang.TabIndex = 9;

            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(668, 355);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(110, 32);
            this.btnLapPhieu.TabIndex = 10;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);

            // 
            // FrmPhongTienNghi
            // 
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.txtPhongBottom);
            this.Controls.Add(this.lblPhongBottom);
            this.Controls.Add(this.txtTienNghi);
            this.Controls.Add(this.lblTienNghi);
            this.Controls.Add(this.txtPhieuLapDat);
            this.Controls.Add(this.lblPhieuLapDat);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtDonGiaNgay);
            this.Controls.Add(this.lblDonGiaNgay);
            this.Controls.Add(this.txtSoNguoiToiDa);
            this.Controls.Add(this.lblSoNguoiToiDa);
            this.Controls.Add(this.txtKhuVuc);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.lblNav);
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.TextBox txtKhuVuc;
        private System.Windows.Forms.Label lblSoNguoiToiDa;
        private System.Windows.Forms.TextBox txtSoNguoiToiDa;
        private System.Windows.Forms.Label lblDonGiaNgay;
        private System.Windows.Forms.TextBox txtDonGiaNgay;

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;

        private System.Windows.Forms.Label lblPhieuLapDat;
        private System.Windows.Forms.TextBox txtPhieuLapDat;
        private System.Windows.Forms.Label lblTienNghi;
        private System.Windows.Forms.TextBox txtTienNghi;
        private System.Windows.Forms.Label lblPhongBottom;
        private System.Windows.Forms.TextBox txtPhongBottom;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;

        private System.Windows.Forms.Button btnLapPhieu;
    }
}