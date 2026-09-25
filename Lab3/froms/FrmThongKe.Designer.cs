namespace QuanLyKhachSan
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.lblDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThuHD = new System.Windows.Forms.Label();
            this.lblTongDenBu = new System.Windows.Forms.Label();
            this.dgvThongKeDichVu = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblTuNgay);
            this.panelTop.Controls.Add(this.dtpTuNgay);
            this.panelTop.Controls.Add(this.lblDenNgay);
            this.panelTop.Controls.Add(this.dtpDenNgay);
            this.panelTop.Controls.Add(this.btnThongKe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 80);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ DOANH THU";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(13, 48);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(49, 13);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(68, 45);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 20);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(210, 48);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(56, 13);
            this.lblDenNgay.TabIndex = 3;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(272, 45);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 20);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(410, 43);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 25);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblPhieuDat);
            this.panelInfo.Controls.Add(this.lblDangO);
            this.panelInfo.Controls.Add(this.lblHoaDon);
            this.panelInfo.Controls.Add(this.lblDoanhThuHD);
            this.panelInfo.Controls.Add(this.lblTongDenBu);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 80);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(900, 60);
            this.panelInfo.TabIndex = 1;
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuDat.Location = new System.Drawing.Point(12, 20);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(90, 16);
            this.lblPhieuDat.TabIndex = 0;
            this.lblPhieuDat.Text = "Phiếu đặt: 0";
            // 
            // lblDangO
            // 
            this.lblDangO.AutoSize = true;
            this.lblDangO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangO.Location = new System.Drawing.Point(140, 20);
            this.lblDangO.Name = "lblDangO";
            this.lblDangO.Size = new System.Drawing.Size(74, 16);
            this.lblDangO.TabIndex = 1;
            this.lblDangO.Text = "Đang ở: 0";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(250, 20);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(82, 16);
            this.lblHoaDon.TabIndex = 2;
            this.lblHoaDon.Text = "Hóa đơn: 0";
            // 
            // lblDoanhThuHD
            // 
            this.lblDoanhThuHD.AutoSize = true;
            this.lblDoanhThuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHD.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDoanhThuHD.Location = new System.Drawing.Point(370, 20);
            this.lblDoanhThuHD.Name = "lblDoanhThuHD";
            this.lblDoanhThuHD.Size = new System.Drawing.Size(147, 16);
            this.lblDoanhThuHD.TabIndex = 3;
            this.lblDoanhThuHD.Text = "Doanh thu HĐ: 0 đ";
            // 
            // lblTongDenBu
            // 
            this.lblTongDenBu.AutoSize = true;
            this.lblTongDenBu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDenBu.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongDenBu.Location = new System.Drawing.Point(580, 20);
            this.lblTongDenBu.Name = "lblTongDenBu";
            this.lblTongDenBu.Size = new System.Drawing.Size(130, 16);
            this.lblTongDenBu.TabIndex = 4;
            this.lblTongDenBu.Text = "Tổng đền bù: 0 đ";
            // 
            // dgvThongKeDichVu
            // 
            this.dgvThongKeDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeDichVu.Location = new System.Drawing.Point(0, 140);
            this.dgvThongKeDichVu.Name = "dgvThongKeDichVu";
            this.dgvThongKeDichVu.ReadOnly = true;
            this.dgvThongKeDichVu.Size = new System.Drawing.Size(900, 360);
            this.dgvThongKeDichVu.TabIndex = 2;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvThongKeDichVu);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblPhieuDat;
        private System.Windows.Forms.Label lblDangO;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblDoanhThuHD;
        private System.Windows.Forms.Label lblTongDenBu;
        private System.Windows.Forms.DataGridView dgvThongKeDichVu;
    }
}