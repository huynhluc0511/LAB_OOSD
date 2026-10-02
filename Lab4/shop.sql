-- Tạo Database (chạy câu lệnh này ngoài Script nếu dùng pgAdmin hoặc psql)
-- CREATE DATABASE eshopping_db WITH ENCODING = 'UTF8';

-- 1. Bảng Nhóm Sản Phẩm
CREATE TABLE NhomSanPham (
    MaNhom VARCHAR(20) NOT NULL PRIMARY KEY,
    TenNhom VARCHAR(100) NOT NULL,
    MoTa VARCHAR(500) NULL
);

-- 2. Bảng Sản Phẩm
CREATE TABLE SanPham (
    MaSP VARCHAR(20) NOT NULL PRIMARY KEY,
    TenSP VARCHAR(200) NOT NULL,
    MaNhom VARCHAR(20) NOT NULL,
    TenNhaSX VARCHAR(100) NOT NULL,
    HinhAnh VARCHAR(500) NULL,
    MoTa TEXT NULL,
    ThongSoKyThuat TEXT NULL,
    GiaBan NUMERIC(18, 2) NOT NULL CHECK (GiaBan >= 0),
    SoLuongTon INT NOT NULL DEFAULT 0 CHECK (SoLuongTon >= 0),
    TinhTrang BOOLEAN NOT NULL DEFAULT TRUE, -- TRUE: Còn hàng, FALSE: Hết hàng
    CONSTRAINT FK_SanPham_NhomSanPham FOREIGN KEY (MaNhom) REFERENCES NhomSanPham(MaNhom)
);

-- 3. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen VARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    CMND_Passport VARCHAR(20) NOT NULL UNIQUE,
    DiaChi VARCHAR(250) NOT NULL,
    DienThoai VARCHAR(15) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(256) NOT NULL, -- Lưu Hash Password
    Email VARCHAR(100) NOT NULL
);

-- 4. Bảng Loại Phiếu Đặt Hàng (Cấu hình hình thức giao hàng)
CREATE TABLE LoaiPhieuDat (
    MaLoaiPhieu VARCHAR(10) NOT NULL PRIMARY KEY, -- STANDARD, EXPRESS, SAMEDAY
    TenLoaiPhieu VARCHAR(50) NOT NULL,
    DonGiaCoBan NUMERIC(18, 2) NOT NULL CHECK (DonGiaCoBan >= 0),
    ThoiGianXuLy VARCHAR(50) NOT NULL
);

-- 5. Bảng Đơn Hàng
CREATE TABLE DonHang (
    MaDonHang VARCHAR(20) NOT NULL PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    NgayDat TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    HoTenNguoiNhan VARCHAR(100) NOT NULL,
    DiaChiNguoiNhan VARCHAR(250) NOT NULL,
    DienThoaiNguoiNhan VARCHAR(15) NOT NULL,
    MaLoaiPhieu VARCHAR(10) NOT NULL,
    PhiGiaoHang NUMERIC(18, 2) NOT NULL DEFAULT 0 CHECK (PhiGiaoHang >= 0),
    TongTienHang NUMERIC(18, 2) NOT NULL CHECK (TongTienHang >= 0),
    TongThanhToan NUMERIC(18, 2) NOT NULL CHECK (TongThanhToan >= 0),
    TrangThai VARCHAR(30) NOT NULL DEFAULT 'PendingPayment',
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_DonHang_LoaiPhieu FOREIGN KEY (MaLoaiPhieu) REFERENCES LoaiPhieuDat(MaLoaiPhieu)
);

-- 6. Bảng Chi Tiết Đơn Hàng
CREATE TABLE ChiTietDonHang (
    MaDonHang VARCHAR(20) NOT NULL,
    MaSP VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia NUMERIC(18, 2) NOT NULL CHECK (DonGia >= 0),
    CONSTRAINT PK_ChiTietDonHang PRIMARY KEY (MaDonHang, MaSP),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang) ON DELETE CASCADE,
    CONSTRAINT FK_CTDH_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- 7. Bảng Nhật Ký Giao Dịch Thanh Toán
CREATE TABLE GiaoDichThanhToan (
    MaGiaoDich VARCHAR(30) NOT NULL PRIMARY KEY,
    MaDonHang VARCHAR(20) NOT NULL,
    LoaiThe VARCHAR(20) NOT NULL, -- VISA, MASTER, DISCOVER, AMEX
    SoTheMasked VARCHAR(20) NOT NULL, -- Ví dụ: **** **** **** 1234
    TenChuThe VARCHAR(100) NOT NULL,
    NgayHetHan VARCHAR(7) NOT NULL, -- MM/YYYY
    SoTienThanhToan NUMERIC(18, 2) NOT NULL,
    PhiGiaoDichThe NUMERIC(18, 2) NOT NULL DEFAULT 0,
    NgayThucHien TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    TrangThaiThanhToan VARCHAR(30) NOT NULL, -- SUCCESS, FAILED
    CONSTRAINT FK_GiaoDich_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang)
);