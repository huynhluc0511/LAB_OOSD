LAB 6 – Hệ thống Quản lý Hồ sơ bệnh án của bệnh nhân
1. Thông tin sinh viên
• Họ và tên: Huỳnh Tấn Lực
• Mã số sinh viên (MSSV): 1250080110
• Lớp: 12_ĐH_CNPM2
2. Thông tin bài Lab
• Tên bài Lab: LAB 6 – Hệ thống Quản lý Hồ sơ bệnh án của bệnh nhân
• Ngày hoàn thành: 16/10/2026
3. Môi trường phát triển
• Hệ điều hành: Windows 11
• Ngôn ngữ lập trình: C#
• Framework: .NET Framework 4.7.2
• IDE: Visual Studio 2022
• Cơ sở dữ liệu: SQL Server
• Công cụ vẽ diagram: Draw.io
4. Giới thiệu hệ thống
Hệ thống Quản lý Hồ sơ bệnh án được xây dựng cho một bệnh viện đa khoa quốc tế, nhằm số hóa toàn bộ quy trình tiếp nhận bệnh nhân, lưu trữ lịch sử khám chữa bệnh và theo dõi sức khỏe lâu dài. Hệ thống hỗ trợ đăng ký và cấp hồ sơ bệnh án, thu lệ phí quản lý hằng năm, đặt hẹn khám sức khỏe định kỳ theo quý, ghi nhận phiếu khám (triệu chứng, xét nghiệm, toa thuốc), thu viện phí khi xuất viện và ghi nhận diễn biến điều trị cùng phản ứng phụ của thuốc.
Theo quy định nghiệp vụ, bệnh nhân khám lần đầu phải lập phiếu đăng ký và đóng lệ phí hằng năm thì mới được cấp hồ sơ bệnh án mang một mã hồ sơ duy nhất. Từ đó, mỗi lần khám sau chỉ cần báo mã hồ sơ (hoặc thông tin tìm kiếm khác) để bác sĩ xem được lý lịch bệnh án và chọn hướng điều trị phù hợp. Bệnh nhân còn hạn lệ phí được khám sức khỏe định kỳ theo quý mà không mất thêm chi phí.
5. Chức năng nghiệp vụ chính
5.1. Đăng ký khám và cấp hồ sơ bệnh án
• Lập phiếu đăng ký gồm: họ tên, địa chỉ, ngày sinh, số điện thoại liên lạc và ảnh chụp 3x4.
• Thu lệ phí quản lý hằng năm; có chức năng gia hạn khi hồ sơ hết hạn.
• Khởi tạo hồ sơ bệnh án: trang bìa ghi mã hồ sơ duy nhất cùng thông tin từ phiếu đăng ký.
• Cho phép cập nhật thông tin phiếu đăng ký, nhưng khóa mã hồ sơ khi sửa.
5.2. Khám bệnh và điều trị
• Tra cứu hồ sơ theo mã hồ sơ (hoặc họ tên, số điện thoại) để xem lý lịch bệnh án và phản ứng phụ trước đó.
• Lập phiếu khám: ngày giờ khám, bác sĩ khám, khoa điều trị, triệu chứng (nhức đầu, thân nhiệt, huyết áp...), chẩn đoán.
• Chỉ định các xét nghiệm cần thiết và ghi nhận kết quả vào chính phiếu khám.
• Kê toa thuốc điều trị; mỗi thuốc ghi rõ số lượng và cách dùng.
5.3. Đặt hẹn khám sức khỏe định kỳ theo quý
• Bệnh nhân gọi đến phòng chăm sóc khách hàng để hẹn chính xác ngày giờ phù hợp với thời gian rảnh của mình.
• Hệ thống kiểm tra hồ sơ còn hạn lệ phí và mỗi quý chỉ nhận một lần khám định kỳ miễn phí.
• Đợt khám định kỳ được lưu như một lần điều trị, kết luận không bệnh hoặc phát hiện sớm mầm bệnh.
• Xem, theo dõi và hủy các lịch hẹn sắp tới.
5.4. Thanh toán viện phí và xuất viện
• Tổng hợp chi phí của đợt khám (xét nghiệm, thuốc, dịch vụ) và thu viện phí khi bệnh nhân làm thủ tục xuất viện.
• Phòng chăm sóc và theo dõi khách hàng ghi nhận lên máy tính toàn bộ phiếu khám sau khi bệnh nhân xuất viện và thanh toán xong.
• Lưu diễn biến bệnh, phản ứng phụ do thuốc và hiệu quả điều trị để theo dõi lâu dài.
5.5. Tra cứu, thống kê và báo cáo
• Tra cứu lịch sử khám của bệnh nhân cùng toa thuốc và kết quả xét nghiệm của từng lần khám.
• Thống kê lượt khám theo khoa, theo bác sĩ (làm rõ trách nhiệm bác sĩ trong các đợt điều trị).
• Thống kê thuốc được kê nhiều, phản ứng phụ và doanh thu lệ phí, viện phí theo khoảng thời gian.
Bảng tổng hợp Đầu vào – Xử lý – Đầu ra
Nhóm nghiệp vụ
Đầu vào
Xử lý chính
Đầu ra
Đăng ký và cấp hồ sơ
Họ tên, ngày sinh, địa chỉ, SĐT, ảnh 3x4, lệ phí hằng năm
Kiểm tra thông tin; lập phiếu đăng ký; xác nhận thu lệ phí; khởi tạo hồ sơ bệnh án
Phiếu đăng ký; hồ sơ bệnh án; mã hồ sơ duy nhất; thẻ bệnh nhân
Đặt hẹn khám định kỳ
Mã hồ sơ hoặc SĐT, thời gian rảnh của bệnh nhân
Kiểm tra hạn lệ phí; tra cứu lịch trống; tạo cuộc hẹn khám theo quý
Lịch hẹn khám định kỳ; thông báo xác nhận hẹn
Khám bệnh và điều trị
Mã hồ sơ, triệu chứng, sinh hiệu (huyết áp, thân nhiệt...), chỉ định xét nghiệm
Tra cứu bệnh án cũ; ghi triệu chứng; chẩn đoán; chỉ định xét nghiệm; kê thuốc
Phiếu khám bệnh; phiếu xét nghiệm; toa thuốc
Xuất viện và viện phí
Phiếu khám, chi phí xét nghiệm, toa thuốc của đợt điều trị
Tổng hợp viện phí; thu tiền; ghi nhận diễn biến bệnh và phản ứng phụ vào CSDL
Hóa đơn viện phí; báo cáo diễn biến và hiệu quả điều trị
Thống kê và tra cứu
Mã hồ sơ, khoảng thời gian thống kê
Truy xuất lý lịch bệnh án; tổng hợp lượt khám; thống kê doanh thu và phản ứng phụ
Báo cáo lịch sử bệnh án; báo cáo lượt khám và doanh thu
Phân loại công việc theo bộ phận
Bộ phận / Actor
Công việc
Loại
Quy định liên quan
Bộ phận Tiếp nhận / CSKH
Lập phiếu đăng ký, thu lệ phí hằng năm, cấp hồ sơ bệnh án
Lưu trữ / Tính toán
Lần đầu đến khám phải đóng lệ phí năm mới được phát hồ sơ
Nhân viên Lễ tân / CSKH
Tiếp nhận cuộc hẹn khám định kỳ theo quý
Tra cứu / Lưu trữ
Hồ sơ còn hạn được khám định kỳ miễn phí; xếp giờ theo lịch rảnh của bệnh nhân
Bác sĩ điều trị
Tra cứu hồ sơ cũ, khám bệnh, ghi triệu chứng, chỉ định xét nghiệm, kê toa
Lưu trữ / Tra cứu
Xem phản ứng phụ và lý lịch bệnh theo mã hồ sơ để điều trị phù hợp
Kỹ thuật viên xét nghiệm
Thực hiện xét nghiệm và cập nhật kết quả
Lưu trữ / Cập nhật
Kết quả được gắn trực tiếp vào phiếu khám bệnh
Bộ phận Kế toán / CSKH
Thu viện phí, ghi nhận dữ liệu sau xuất viện
Tính toán / Lưu trữ
Chỉ cho xuất viện khi đã hoàn tất viện phí; lưu diễn biến bệnh và phản ứng phụ
6. Quy tắc nghiệp vụ (Business Rules)
ID
Quy tắc
BR01
Bệnh nhân khám lần đầu phải lập phiếu đăng ký và đóng lệ phí quản lý hằng năm thì mới được cấp hồ sơ bệnh án.
BR02
Mỗi hồ sơ bệnh án có một mã hồ sơ duy nhất ghi trên trang bìa để phân biệt giữa các bệnh nhân.
BR03
Hồ sơ còn hạn lệ phí hằng năm được quyền khám sức khỏe định kỳ theo quý miễn phí.
BR04
Lịch hẹn khám định kỳ phải được xác nhận phù hợp với thời gian rảnh của bệnh nhân và lịch làm việc của bác sĩ.
BR05
Mỗi lượt khám thuộc về đúng một hồ sơ bệnh án và do một bác sĩ phụ trách.
BR06
Mỗi phiếu khám có thể có 0 hoặc nhiều xét nghiệm và 0 hoặc 1 toa thuốc.
BR07
Mỗi toa thuốc gồm một hoặc nhiều thuốc; mỗi thuốc ghi rõ số lượng, liều dùng và cách dùng.
BR08
Đợt khám sức khỏe định kỳ được lưu như một đợt điều trị (có thể kết luận không bệnh hoặc phát hiện sớm mầm bệnh).
BR09
Diễn biến bệnh, tác dụng phụ của thuốc và viện phí chỉ được ghi nhận hoàn tất vào máy tính sau khi bệnh nhân xuất viện.
BR10
Bệnh nhân phải thanh toán đủ 100% viện phí của đợt khám thì mới được làm thủ tục xuất viện.
Lưu ý nghiệp vụ: Tài liệu chưa nêu rõ trường hợp hồ sơ hết hạn lệ phí ngay giữa quý (ví dụ hẹn khám trước ngày hết hạn nhưng đến khám sau ngày đó). Cần thống nhất quy tắc này trước khi triển khai kiểm tra dữ liệu; trong bài lab tạm quy ước hồ sơ phải còn hạn tại ngày hẹn và mỗi quý chỉ được một lần khám định kỳ miễn phí.
7. Yêu cầu chức năng
• Kiểm tra dữ liệu: Không để trống khóa chính hoặc trường bắt buộc (mã hồ sơ, mã bệnh nhân, mã bác sĩ); số lượng thuốc kê phải lớn hơn 0; kiểm tra ngày sinh, thân nhiệt hợp lệ; kiểm tra hạn lệ phí hằng năm khi đặt hẹn hoặc lập phiếu khám.
• Giao dịch dữ liệu: Khởi tạo hồ sơ cùng lệ phí, lập phiếu khám kèm toa thuốc và xét nghiệm, thu viện phí khi xuất viện được gói trong SqlTransaction để tránh cập nhật dở dang.
• Thông báo trạng thái: Mọi thao tác đều báo thành công hoặc nêu rõ lý do từ chối, chẳng hạn hồ sơ hết hạn lệ phí, trùng lịch hẹn, quý này đã khám định kỳ, chưa đóng đủ viện phí.
• Tra cứu: Hỗ trợ chọn khóa ngoại bằng ComboBox (khoa, bác sĩ, thuốc, xét nghiệm); DataGridView hiển thị lịch sử các đợt khám, toa thuốc và kết quả xét nghiệm.
• Ngăn thao tác rủi ro: Khóa mã hồ sơ khi sửa thông tin; dùng ràng buộc khóa ngoại để chặn xóa bệnh nhân hoặc hồ sơ đã phát sinh lịch sử khám.
8. Yêu cầu phi chức năng
• Tính tiện dụng: Giao diện bố trí theo đúng quy trình khám bệnh; tên điều khiển nhất quán (ví dụ txtMaHoSo, btnLuu, dgvLichSu); xem lịch sử khám chỉ với một lần nhấp chuột.
• Hiệu quả: Truy vấn có điều kiện và đánh chỉ mục trên mã hồ sơ; chỉ tải dữ liệu cần thiết; tra cứu và hiển thị toàn bộ lịch sử khám dưới 1,5 giây; dùng transaction khi cập nhật nhiều bảng.
• Khả năng bảo trì: Tách UI, Service và Data Access để thay đổi quy trình thanh toán hoặc danh mục thuốc ít ảnh hưởng đến giao diện.
• Tương thích: Visual Studio 2022, .NET Framework 4.7.2, SQL Server LocalDB/Express và ADO.NET.
9. Các mối quan hệ lớp chính
STT
Quan hệ
Bội số
Ý nghĩa
1
BenhNhan – HoSoBenhAn
1–1
Mỗi bệnh nhân được cấp một hồ sơ bệnh án mang mã hồ sơ duy nhất.
2
HoSoBenhAn – LePhiHangNam
1–N
Một hồ sơ có thể đóng hoặc gia hạn lệ phí nhiều năm; mỗi lần đóng gắn với một hồ sơ.
3
HoSoBenhAn – PhieuKhamBenh
1–N
Một hồ sơ có nhiều phiếu khám; mỗi phiếu thuộc đúng một hồ sơ.
4
BacSi – PhieuKhamBenh
1–N
Một bác sĩ phụ trách nhiều phiếu khám; mỗi phiếu do một bác sĩ phụ trách.
5
Khoa – BacSi
1–N
Một khoa có nhiều bác sĩ; mỗi bác sĩ thuộc một khoa.
6
PhieuKhamBenh – ToaThuoc
1–0..1
Một phiếu khám có thể không có hoặc có một toa thuốc.
7
ToaThuoc – ChiTietToaThuoc
1–N
Một toa thuốc có từ một đến nhiều dòng thuốc; quan hệ Composition.
8
Thuoc – ChiTietToaThuoc
1–N
Một loại thuốc có thể xuất hiện trong nhiều dòng chi tiết toa.
9
PhieuKhamBenh – PhieuXetNghiem
1–N
Một phiếu khám có thể chỉ định 0 hoặc nhiều xét nghiệm.
10
HoSoBenhAn – CuocHen
1–N
Một hồ sơ có thể đặt nhiều cuộc hẹn khám định kỳ; mỗi cuộc hẹn thuộc một hồ sơ.
11
PhieuKhamBenh – HoaDon
1–0..1
Mỗi phiếu khám có tối đa một hóa đơn viện phí, được lập khi xuất viện.
10. Hướng dẫn thiết lập và chạy chương trình
1. Cài đặt Visual Studio 2022 và workload phát triển ứng dụng .NET desktop.
2. Cài đặt hoặc bật SQL Server LocalDB/SQL Server Express (kèm SQL Server Management Studio).
3. Mở file QuanLyBenhAn.sln của dự án trong Visual Studio.
4. Chạy script Database/QuanLyBenhAn.sql trong SSMS để tạo cơ sở dữ liệu QuanLyBenhAn cùng dữ liệu mẫu.
5. Kiểm tra chuỗi kết nối trong lớp Db.cs (mặc định Data Source=. ; Integrated Security=True; nếu dùng SQL Express thì đổi thành .\SQLEXPRESS).
6. Kiểm tra các khóa chính, khóa ngoại và dữ liệu tham chiếu (khoa, bác sĩ, thuốc, xét nghiệm).
7. Build solution, xử lý lỗi nếu có, sau đó nhấn Start (F5) để chạy ứng dụng.
11. Kết quả đạt được
Theo nội dung báo cáo LAB 5, phần phân tích và thiết kế đã hoàn thành gồm:
• Mô tả hoạt động nghiệp vụ và yêu cầu hệ thống.
• Xác định các quy tắc nghiệp vụ BR01–BR10.
• Tổng hợp yêu cầu chức năng và phi chức năng.
• Thiết kế UML: 9 Use Case (đặc tả, Activity Diagram, Sequence Diagram), Class Diagram và Use Case Diagram tổng quát.
• Mô tả các mối quan hệ và bội số giữa các lớp trong mô hình lớp.
Ở LAB 6, hệ thống được hiện thực bằng C# WinForms kết hợp SQL Server:
• Cơ sở dữ liệu QuanLyBenhAn với các bảng chính: BenhNhan, DangKy, PhieuKham, ToaThuoc, KetQuaXN, LichHen và các bảng danh mục Khoa, BacSi, Thuoc, XetNghiem.
• Các form: FrmMain, FrmDanhMuc, FrmDangKy, FrmPhieuKham, FrmHenKham, FrmTraCuu, FrmThongKe, xử lý đúng các quy tắc nghiệp vụ của bệnh viện.
Danh sách Use Case của hệ thống:
STT
Mã Use Case
Tên Use Case
Tác nhân liên quan
1
UC01
Đăng ký khám ban đầu và cấp hồ sơ
Bệnh nhân, Nhân viên CSKH
2
UC02
Thu / gia hạn lệ phí hằng năm
Bệnh nhân, Nhân viên CSKH
3
UC03
Đặt hẹn khám định kỳ theo quý
Bệnh nhân, Nhân viên CSKH
4
UC04
Tra cứu và xem lý lịch bệnh án
Bác sĩ, Nhân viên CSKH
5
UC05
Khám bệnh và ghi nhận triệu chứng
Bác sĩ, Bệnh nhân
6
UC06
Chỉ định và trả kết quả xét nghiệm
Bác sĩ, Kỹ thuật viên / CSKH
7
UC07
Lập toa thuốc (kê đơn)
Bác sĩ
8
UC08
Thanh toán viện phí và xuất viện
Bệnh nhân, Nhân viên CSKH
9
UC09
Ghi nhận diễn biến và phản ứng phụ
Nhân viên CSKH
[Chèn ảnh chụp giao diện đăng ký hồ sơ / phiếu khám bệnh tại đây]
12. Lỗi gặp phải và cách khắc phục
STT
Lỗi gặp phải
Nguyên nhân