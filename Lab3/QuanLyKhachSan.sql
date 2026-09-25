-- Xóa bảng cũ nếu tồn tại theo thứ tự phụ thuộc khóa ngoại
DROP TABLE IF EXISTS ThanhToan CASCADE;
DROP TABLE IF EXISTS HoaDon CASCADE;
DROP TABLE IF EXISTS ChiTietPhieuDenBu CASCADE;
DROP TABLE IF EXISTS PhieuDenBu CASCADE;
DROP TABLE IF EXISTS QuyDinhDenBu CASCADE;
DROP TABLE IF EXISTS ChiTietPhieuSuDungDV CASCADE;
DROP TABLE IF EXISTS PhieuSuDungDV CASCADE;
DROP TABLE IF EXISTS DichVu CASCADE;
DROP TABLE IF EXISTS NguoiLuuTru CASCADE;
DROP TABLE IF EXISTS ChiTietDatPhong CASCADE;
DROP TABLE IF EXISTS PhieuDatPhong CASCADE;
DROP TABLE IF EXISTS KhachHang CASCADE;
DROP TABLE IF EXISTS PhieuLapDat CASCADE;
DROP TABLE IF EXISTS TienNghi CASCADE;
DROP TABLE IF EXISTS LoaiTienNghi CASCADE;
DROP TABLE IF EXISTS Phong CASCADE;
DROP TABLE IF EXISTS KhuVuc CASCADE;
DROP TABLE IF EXISTS NhanVien CASCADE;

-- 1. Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    HoTen varchar(120) NOT NULL,
    VaiTro varchar(50) NOT NULL,
    SoDienThoai varchar(20) NULL
);

-- 2. Bảng Khu Vực
CREATE TABLE KhuVuc (
    MaKhuVuc varchar(20) NOT NULL PRIMARY KEY,
    TenKhuVuc varchar(100) NOT NULL UNIQUE
);

-- 3. Bảng Phòng
CREATE TABLE Phong (
    SoPhong varchar(20) NOT NULL PRIMARY KEY,
    MaKhuVuc varchar(20) NOT NULL,
    SoNguoiToiDa int NOT NULL CHECK(SoNguoiToiDa > 0),
    DonGiaNgay numeric(18,2) NOT NULL CHECK(DonGiaNgay >= 0),
    TrangThai varchar(30) NOT NULL DEFAULT 'Trống',
    CONSTRAINT CK_Phong_TrangThai CHECK(TrangThai IN ('Trống', 'Đã đặt', 'Đang ở', 'Bảo trì')),
    CONSTRAINT FK_Phong_KhuVuc FOREIGN KEY(MaKhuVuc) REFERENCES KhuVuc(MaKhuVuc)
);

-- 4. Bảng Loại Tiện Nghi
CREATE TABLE LoaiTienNghi (
    MaLoaiTN varchar(20) NOT NULL PRIMARY KEY,
    TenLoaiTN varchar(100) NOT NULL UNIQUE
);

-- 5. Bảng Tiện Nghi
CREATE TABLE TienNghi (
    MaTienNghi varchar(30) NOT NULL PRIMARY KEY,
    MaLoaiTN varchar(20) NOT NULL,
    SoThuTu int NOT NULL,
    TinhTrangHienTai varchar(100) NULL,
    CONSTRAINT UQ_TienNghi_Loai_STT UNIQUE(MaLoaiTN, SoThuTu),
    CONSTRAINT FK_TienNghi_Loai FOREIGN KEY(MaLoaiTN) REFERENCES LoaiTienNghi(MaLoaiTN)
);

-- 6. Bảng Phiếu Lắp Đặt
CREATE TABLE PhieuLapDat (
    SoPhieuLapDat varchar(30) NOT NULL PRIMARY KEY,
    MaTienNghi varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    NgayLap date NOT NULL,
    TinhTrang varchar(100) NOT NULL,
    MaNV varchar(20) NOT NULL,
    GhiChu varchar(250) NULL,
    CONSTRAINT UQ_PhieuLapDat_ThietBi_Ngay UNIQUE(MaTienNghi, NgayLap),
    CONSTRAINT FK_PhieuLapDat_TienNghi FOREIGN KEY(MaTienNghi) REFERENCES TienNghi(MaTienNghi),
    CONSTRAINT FK_PhieuLapDat_Phong FOREIGN KEY(SoPhong) REFERENCES Phong(SoPhong),
    CONSTRAINT FK_PhieuLapDat_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- 7. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKhach varchar(20) NOT NULL PRIMARY KEY,
    HoTen varchar(120) NOT NULL,
    SoCMND varchar(30) NOT NULL UNIQUE,
    QuocTich varchar(80) NOT NULL,
    SoDienThoai varchar(20) NULL
);

-- 8. Bảng Phiếu Đặt Phòng
CREATE TABLE PhieuDatPhong (
    SoPhieuDat varchar(30) NOT NULL PRIMARY KEY,
    MaKhach varchar(20) NOT NULL,
    MaNVLeTan varchar(20) NOT NULL,
    NgayLap timestamp NOT NULL,
    NgayNhan date NOT NULL,
    NgayTraDuKien date NOT NULL,
    TienCoc numeric(18,2) NOT NULL DEFAULT 0 CHECK(TienCoc >= 0),
    KenhDat varchar(20) NOT NULL,
    TrangThai varchar(30) NOT NULL DEFAULT 'Đã đặt',
    NgayNhanThucTe timestamp NULL,
    NgayTraThucTe timestamp NULL,
    CONSTRAINT CK_PhieuDat_Ngay CHECK(NgayTraDuKien >= NgayNhan),
    CONSTRAINT CK_PhieuDat_Kenh CHECK(KenhDat IN ('Điện thoại', 'Website', 'Trực tiếp')),
    CONSTRAINT CK_PhieuDat_TrangThai CHECK(TrangThai IN ('Đã đặt', 'Đang ở', 'Đã trả', 'No-show', 'Hủy')),
    CONSTRAINT FK_PhieuDat_Khach FOREIGN KEY(MaKhach) REFERENCES KhachHang(MaKhach),
    CONSTRAINT FK_PhieuDat_NV FOREIGN KEY(MaNVLeTan) REFERENCES NhanVien(MaNV)
);

-- 9. Bảng Chi Tiết Đặt Phòng
CREATE TABLE ChiTietDatPhong (
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    SoNguoi int NOT NULL CHECK(SoNguoi > 0),
    PRIMARY KEY (SoPhieuDat, SoPhong),
    CONSTRAINT FK_CTDat_Phieu FOREIGN KEY(SoPhieuDat) REFERENCES PhieuDatPhong(SoPhieuDat),
    CONSTRAINT FK_CTDat_Phong FOREIGN KEY(SoPhong) REFERENCES Phong(SoPhong)
);

-- 10. Bảng Người Lưu Trú
CREATE TABLE NguoiLuuTru (
    MaNguoiLT SERIAL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    HoTen varchar(120) NOT NULL,
    SoCMND varchar(30) NOT NULL,
    QuocTich varchar(80) NOT NULL,
    CONSTRAINT FK_NguoiLT_CTDat FOREIGN KEY(SoPhieuDat, SoPhong) REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong)
);

-- 11. Bảng Dịch Vụ
CREATE TABLE DichVu (
    MaDV varchar(20) NOT NULL PRIMARY KEY,
    TenDV varchar(120) NOT NULL,
    DonViTinh varchar(40) NOT NULL,
    DonGia numeric(18,2) NOT NULL CHECK(DonGia >= 0)
);

-- 12. Bảng Phiếu Sử Dụng Dịch Vụ
CREATE TABLE PhieuSuDungDV (
    SoPhieuSDDV varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    NgaySuDung date NOT NULL,
    MaNV varchar(20) NOT NULL,
    CONSTRAINT UQ_PhieuSDDV_PhongNgay UNIQUE(SoPhieuDat, SoPhong, NgaySuDung),
    CONSTRAINT FK_PhieuSDDV_CTDat FOREIGN KEY(SoPhieuDat, SoPhong) REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong),
    CONSTRAINT FK_PhieuSDDV_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- 13. Bảng Chi Tiết Phiếu Sử Dụng Dịch Vụ
CREATE TABLE ChiTietPhieuSuDungDV (
    SoPhieuSDDV varchar(30) NOT NULL,
    MaDV varchar(20) NOT NULL,
    SoLuong int NOT NULL CHECK(SoLuong > 0),
    DonGia numeric(18,2) NOT NULL CHECK(DonGia >= 0),
    ThanhTien numeric(18,2) GENERATED ALWAYS AS (SoLuong * DonGia) STORED,
    PRIMARY KEY (SoPhieuSDDV, MaDV),
    CONSTRAINT FK_CTSDDV_Phieu FOREIGN KEY (SoPhieuSDDV) REFERENCES PhieuSuDungDV(SoPhieuSDDV),
    CONSTRAINT FK_CTSDDV_DV FOREIGN KEY(MaDV) REFERENCES DichVu(MaDV)
);

-- 14. Bảng Quy Định Đền Bù
CREATE TABLE QuyDinhDenBu (
    MaQuyDinh varchar(30) NOT NULL PRIMARY KEY,
    MaLoaiTN varchar(20) NOT NULL,
    MucDoThietHai varchar(80) NOT NULL,
    MucDenBu numeric(18,2) NOT NULL CHECK(MucDenBu >= 0),
    CONSTRAINT UQ_QDDB_Loai_MucDo UNIQUE(MaLoaiTN, MucDoThietHai),
    CONSTRAINT FK_QDDB_Loai FOREIGN KEY(MaLoaiTN) REFERENCES LoaiTienNghi(MaLoaiTN)
);

-- 15. Bảng Phiếu Đền Bù
CREATE TABLE PhieuDenBu (
    SoPhieuDenBu varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    NgayLap timestamp NOT NULL,
    MaNV varchar(20) NOT NULL,
    TongTien numeric(18,2) NOT NULL DEFAULT 0 CHECK(TongTien >= 0),
    CONSTRAINT FK_PhieuDB_CTDat FOREIGN KEY(SoPhieuDat, SoPhong) REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong),
    CONSTRAINT FK_PhieuDB_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- 16. Bảng Chi Tiết Phiếu Đền Bù
CREATE TABLE ChiTietPhieuDenBu (
    SoPhieuDenBu varchar(30) NOT NULL,
    MaTienNghi varchar(30) NOT NULL,
    MucDoThietHai varchar(80) NOT NULL,
    SoTien numeric(18,2) NOT NULL CHECK(SoTien >= 0),
    PRIMARY KEY (SoPhieuDenBu, MaTienNghi),
    CONSTRAINT FK_CTDB_Phieu FOREIGN KEY (SoPhieuDenBu) REFERENCES PhieuDenBu(SoPhieuDenBu),
    CONSTRAINT FK_CTDB_TienNghi FOREIGN KEY(MaTienNghi) REFERENCES TienNghi(MaTienNghi)
);

-- 17. Bảng Hóa Đơn
CREATE TABLE HoaDon (
    SoHoaDon varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL UNIQUE,
    NgayLap timestamp NOT NULL,
    MaNV varchar(20) NOT NULL,
    SoNgayTinhTien int NOT NULL CHECK(SoNgayTinhTien > 0),
    TienPhong numeric(18,2) NOT NULL CHECK(TienPhong >= 0),
    TienDichVu numeric(18,2) NOT NULL CHECK(TienDichVu >= 0),
    TongTien numeric(18,2) GENERATED ALWAYS AS (TienPhong + TienDichVu) STORED,
    TrangThai varchar(30) NOT NULL DEFAULT 'Chưa thanh toán',
    CONSTRAINT CK_HoaDon_TrangThai CHECK(TrangThai IN ('Chưa thanh toán', 'Đã thanh toán')),
    CONSTRAINT FK_HoaDon_PhieuDat FOREIGN KEY(SoPhieuDat) REFERENCES PhieuDatPhong(SoPhieuDat),
    CONSTRAINT FK_HoaDon_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- 18. Bảng Thanh Toán
CREATE TABLE ThanhToan (
    MaThanhToan varchar(30) NOT NULL PRIMARY KEY,
    SoHoaDon varchar(30) NOT NULL,
    NgayThanhToan timestamp NOT NULL,
    HinhThuc varchar(30) NOT NULL,
    SoTien numeric(18,2) NOT NULL CHECK(SoTien > 0),
    CONSTRAINT CK_ThanhToan_HinhThuc CHECK(HinhThuc IN ('Tiền mặt', 'Chuyển khoản', 'Thẻ', 'Ví điện tử')),
    CONSTRAINT FK_ThanhToan_HoaDon FOREIGN KEY(SoHoaDon) REFERENCES HoaDon(SoHoaDon)
);

-- Index hỗ trợ tốc độ tìm kiếm
CREATE INDEX IX_PhieuDatPhong_Ngay ON PhieuDatPhong(NgayNhan, NgayTraDuKien, TrangThai);
CREATE INDEX IX_CTDat_Phong ON ChiTietDatPhong(SoPhong, SoPhieuDat);
CREATE INDEX IX_PhieuSDDV_DatPhong ON PhieuSuDungDV(SoPhieuDat, SoPhong, NgaySuDung);

-- Chèn dữ liệu thử nghiệm ban đầu
INSERT INTO NhanVien(MaNV, HoTen, VaiTro, SoDienThoai) VALUES
('NV01', 'Nguyễn Thu Hà', 'Lễ tân', '0901000001'),
('NV02', 'Trần Minh An', 'Phục vụ phòng', '0901000002'),
('NV03', 'Lê Hoàng Nam', 'Thanh toán', '0901000003');

INSERT INTO KhuVuc(MaKhuVuc, TenKhuVuc) VALUES 
('A', 'Khu A'), 
('B', 'Khu B');

INSERT INTO Phong(SoPhong, MaKhuVuc, SoNguoiToiDa, DonGiaNgay, TrangThai) VALUES
('A101', 'A', 2, 600000, 'Trống'), 
('A102', 'A', 3, 800000, 'Trống'),
('B201', 'B', 4, 1200000, 'Trống');

INSERT INTO LoaiTienNghi (MaLoaiTN, TenLoaiTN) VALUES 
('TV', 'Ti vi'), 
('TL', 'Tủ lạnh'), 
('DT', 'Điện thoại');

INSERT INTO TienNghi(MaTienNghi, MaLoaiTN, SoThuTu, TinhTrangHienTai) VALUES
('TV01', 'TV', 1, 'Tốt'),
('TV02', 'TV', 2, 'Tốt'),
('TL01', 'TL', 1, 'Tốt');

INSERT INTO DichVu(MaDV, TenDV, DonViTinh, DonGia) VALUES
('DV01', 'Ăn sáng', 'Suất', 120000),
('DV02', 'Tắm hơi', 'Lượt', 250000), 
('DV03', 'Karaoke', 'Giờ', 300000);

INSERT INTO QuyDinhDenBu(MaQuyDinh, MaLoaiTN, MucDoThietHai, MucDenBu) VALUES
('QD01', 'TV', 'Hư hỏng nhẹ', 500000),
('QD02', 'TV', 'Mất', 5000000), 
('QD03', 'TL', 'Hư hỏng nhẹ', 400000), 
('QD04', 'TL', 'Mất', 4000000);