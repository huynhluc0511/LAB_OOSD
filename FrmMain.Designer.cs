namespace QuanLyBenhAn.Forms
{
    partial class FrmMain
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnPhieuKham = new System.Windows.Forms.Button();
            this.btnHenKham = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Location = new System.Drawing.Point(190, 94);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lblTieuDe.Text = "Hệ Thống Quản Lý Bệnh Án";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Location = new System.Drawing.Point(262, 150);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.Navy;
            this.lblPhuDe.Text = "Bệnh viện đa khoa quốc tế";
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Location = new System.Drawing.Point(106, 223);
            this.btnDanhMuc.Size = new System.Drawing.Size(233, 46);
            this.btnDanhMuc.TabIndex = 2;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnDanhMuc.Text = "DANH MỤC";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Location = new System.Drawing.Point(385, 223);
            this.btnDangKy.Size = new System.Drawing.Size(233, 46);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnDangKy.Text = "ĐĂNG KÝ - HỒ SƠ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnPhieuKham
            // 
            this.btnPhieuKham.Name = "btnPhieuKham";
            this.btnPhieuKham.Location = new System.Drawing.Point(681, 223);
            this.btnPhieuKham.Size = new System.Drawing.Size(233, 46);
            this.btnPhieuKham.TabIndex = 4;
            this.btnPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPhieuKham.Text = "PHIẾU KHÁM BỆNH";
            this.btnPhieuKham.UseVisualStyleBackColor = true;
            this.btnPhieuKham.Click += new System.EventHandler(this.btnPhieuKham_Click);
            // 
            // btnHenKham
            // 
            this.btnHenKham.Name = "btnHenKham";
            this.btnHenKham.Location = new System.Drawing.Point(106, 297);
            this.btnHenKham.Size = new System.Drawing.Size(233, 46);
            this.btnHenKham.TabIndex = 5;
            this.btnHenKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnHenKham.Text = "HẸN KHÁM ĐỊNH KỲ";
            this.btnHenKham.UseVisualStyleBackColor = true;
            this.btnHenKham.Click += new System.EventHandler(this.btnHenKham_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Location = new System.Drawing.Point(385, 297);
            this.btnTraCuu.Size = new System.Drawing.Size(233, 46);
            this.btnTraCuu.TabIndex = 6;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnTraCuu.Text = "TRA CỨU BỆNH ÁN";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Location = new System.Drawing.Point(681, 297);
            this.btnThongKe.Size = new System.Drawing.Size(233, 46);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Location = new System.Drawing.Point(385, 391);
            this.btnThoat.Size = new System.Drawing.Size(233, 46);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 531);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnHenKham);
            this.Controls.Add(this.btnPhieuKham);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblPhuDe);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bệnh Án";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnPhieuKham;
        private System.Windows.Forms.Button btnHenKham;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}
