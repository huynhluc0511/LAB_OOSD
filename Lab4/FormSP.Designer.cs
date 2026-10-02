namespace WindowsFormsApp1.eshop
{
    partial class FormSP
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cboNhomSP = new System.Windows.Forms.ComboBox();
            this.lblNhomSP = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.numSoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongMua = new System.Windows.Forms.Label();
            this.numSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtTenNhaSX = new System.Windows.Forms.TextBox();
            this.lblTenNhaSX = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(984, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH & QUẢN LÝ SẢN PHẨM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnLamMoi);
            this.grpFilter.Controls.Add(this.btnTimKiem);
            this.grpFilter.Controls.Add(this.txtTimKiem);
            this.grpFilter.Controls.Add(this.lblTimKiem);
            this.grpFilter.Controls.Add(this.cboNhomSP);
            this.grpFilter.Controls.Add(this.lblNhomSP);
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.Location = new System.Drawing.Point(12, 53);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(960, 65);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Bộ lọc & Tìm kiếm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(845, 22);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(739, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(460, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 25);
            this.txtTimKiem.TabIndex = 3;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(385, 28);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(63, 17);
            this.lblTimKiem.TabIndex = 2;
            this.lblTimKiem.Text = "Từ khóa:";
            // 
            // cboNhomSP
            // 
            this.cboNhomSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomSP.FormattingEnabled = true;
            this.cboNhomSP.Location = new System.Drawing.Point(130, 25);
            this.cboNhomSP.Name = "cboNhomSP";
            this.cboNhomSP.Size = new System.Drawing.Size(220, 25);
            this.cboNhomSP.TabIndex = 1;
            this.cboNhomSP.SelectedIndexChanged += new System.EventHandler(this.cboNhomSP_SelectedIndexChanged);
            // 
            // lblNhomSP
            // 
            this.lblNhomSP.AutoSize = true;
            this.lblNhomSP.Location = new System.Drawing.Point(15, 28);
            this.lblNhomSP.Name = "lblNhomSP";
            this.lblNhomSP.Size = new System.Drawing.Size(109, 17);
            this.lblNhomSP.TabIndex = 0;
            this.lblNhomSP.Text = "Nhóm sản phẩm:";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 128);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(610, 420);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.btnThemVaoGio);
            this.grpChiTiet.Controls.Add(this.numSoLuongMua);
            this.grpChiTiet.Controls.Add(this.lblSoLuongMua);
            this.grpChiTiet.Controls.Add(this.numSoLuongTon);
            this.grpChiTiet.Controls.Add(this.lblSoLuongTon);
            this.grpChiTiet.Controls.Add(this.numGiaBan);
            this.grpChiTiet.Controls.Add(this.lblGiaBan);
            this.grpChiTiet.Controls.Add(this.txtTenNhaSX);
            this.grpChiTiet.Controls.Add(this.lblTenNhaSX);
            this.grpChiTiet.Controls.Add(this.txtTenSP);
            this.grpChiTiet.Controls.Add(this.lblTenSP);
            this.grpChiTiet.Controls.Add(this.txtMaSP);
            this.grpChiTiet.Controls.Add(this.lblMaSP);
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiTiet.Location = new System.Drawing.Point(632, 128);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(340, 420);
            this.grpChiTiet.TabIndex = 3;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Thông tin chi tiết sản phẩm";
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(20, 345);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(300, 45);
            this.btnThemVaoGio.TabIndex = 12;
            this.btnThemVaoGio.Text = "THÊM VÀO GIỎ HÀNG";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // numSoLuongMua
            // 
            this.numSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuongMua.Location = new System.Drawing.Point(125, 290);
            this.numSoLuongMua.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuongMua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuongMua.Name = "numSoLuongMua";
            this.numSoLuongMua.Size = new System.Drawing.Size(195, 25);
            this.numSoLuongMua.TabIndex = 11;
            this.numSoLuongMua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuongMua
            // 
            this.lblSoLuongMua.AutoSize = true;
            this.lblSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongMua.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSoLuongMua.Location = new System.Drawing.Point(15, 292);
            this.lblSoLuongMua.Name = "lblSoLuongMua";
            this.lblSoLuongMua.Size = new System.Drawing.Size(98, 17);
            this.lblSoLuongMua.TabIndex = 10;
            this.lblSoLuongMua.Text = "Số lượng mua:";
            // 
            // numSoLuongTon
            // 
            this.numSoLuongTon.Enabled = false;
            this.numSoLuongTon.Location = new System.Drawing.Point(125, 240);
            this.numSoLuongTon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSoLuongTon.Name = "numSoLuongTon";
            this.numSoLuongTon.Size = new System.Drawing.Size(195, 25);
            this.numSoLuongTon.TabIndex = 9;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(15, 242);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(89, 17);
            this.lblSoLuongTon.TabIndex = 8;
            this.lblSoLuongTon.Text = "Số lượng tồn:";
            // 
            // numGiaBan
            // 
            this.numGiaBan.Enabled = false;
            this.numGiaBan.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGiaBan.Location = new System.Drawing.Point(125, 190);
            this.numGiaBan.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(195, 25);
            this.numGiaBan.TabIndex = 7;
            this.numGiaBan.ThousandsSeparator = true;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(15, 192);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(87, 17);
            this.lblGiaBan.TabIndex = 6;
            this.lblGiaBan.Text = "Giá bán (VNĐ):";
            // 
            // txtTenNhaSX
            // 
            this.txtTenNhaSX.ReadOnly = true;
            this.txtTenNhaSX.Location = new System.Drawing.Point(125, 140);
            this.txtTenNhaSX.Name = "txtTenNhaSX";
            this.txtTenNhaSX.Size = new System.Drawing.Size(195, 25);
            this.txtTenNhaSX.TabIndex = 5;
            // 
            // lblTenNhaSX
            // 
            this.lblTenNhaSX.AutoSize = true;
            this.lblTenNhaSX.Location = new System.Drawing.Point(15, 143);
            this.lblTenNhaSX.Name = "lblTenNhaSX";
            this.lblTenNhaSX.Size = new System.Drawing.Size(88, 17);
            this.lblTenNhaSX.TabIndex = 4;
            this.lblTenNhaSX.Text = "Nhà sản xuất:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Location = new System.Drawing.Point(125, 90);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(195, 25);
            this.txtTenSP.TabIndex = 3;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(15, 93);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(92, 17);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Location = new System.Drawing.Point(125, 40);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(195, 25);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(15, 43);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(91, 17);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // FormSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý & Xem Sản Phẩm - eShopping";
            this.Load += new System.EventHandler(this.FormSP_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cboNhomSP;
        private System.Windows.Forms.Label lblNhomSP;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenNhaSX;
        private System.Windows.Forms.Label lblTenNhaSX;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.NumericUpDown numSoLuongTon;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.NumericUpDown numSoLuongMua;
        private System.Windows.Forms.Label lblSoLuongMua;
        private System.Windows.Forms.Button btnThemVaoGio;
    }
}