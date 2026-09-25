Huỳnh Tấn Lực-1250080110
lab3: Quản lý khách sạn
MÔI TRƯỜNG & PHIÊN BẢN PHẦN MỀM
Hệ điều hành:Windows 10
Môi trường phát triển (IDE): Visual Studio 2022 / 2019
Nền tảng:.NET Framework / WinForms C#
Hệ quản trị CSDL: PostgreSQL 14+ (Quản lý qua pgAdmin 4)
Thư viện kết nối:Npgsql (Phiên bản 4.1.12)
 3. NỘI DUNG ĐÃ THỰC HIỆN
1. Thiết kế Giao diện (WinForms):
  Xây dựng giao diện chính `FrmMain` bao gồm các điều hướng: Danh mục, Phòng - Tiện nghi, Đặt/Nhận phòng, Sử dụng dịch vụ, Trả phòng - thanh toán, Thống kê, Thoát.
  Thiết kế giao diện `FrmDanhMuc` bao gồm các danh sách `DataGridView` và ô nhập liệu `TextBox`, `Label` cho Khu vực, Dịch vụ, Loại tiện nghi.
2. Xây dựng Lớp Kết nối CSDL (`Db.cs`):
   Viết hàm `Query(sql)` xử lý truy vấn dữ liệu (`SELECT`) trả về `DataTable`.
   Viết hàm `Execute(sql)` xử lý các thao tác thêm, sửa, xóa (`INSERT`, `UPDATE`, `DELETE`).
3. Cấu hình CSDL PostgreSQL:
   Tạo cơ sở dữ liệu `QuanLyKhachSan`.
   Tạo các bảng dữ liệu `KhuVuc`, `DichVu`, `LoaiTienNghi` và thêm dữ liệu mẫu.