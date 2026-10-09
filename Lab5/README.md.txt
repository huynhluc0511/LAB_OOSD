BÁO CÁO KẾT QUẢ BÀI LAB 5
Hệ thống Phân tích & Thiết kế "QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM"
1. THÔNG TIN SINH VIÊN & BÀI LAB
•	Họ và tên: Huỳnh Tấn Lực
•	Mã số sinh viên (MSSV): 1250080110
•	Lớp: 12_ĐH_CNPM2
Tên bài Lab: LAB 5 - Hệ thống Phân tích & Thiết kế "QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM"
Ngày hoàn thành: 09/10/2026

2. Môi trường & Phiên bản (Environment)
•	Hệ điều hành: Windows 11
•	Ngôn ngữ lập trình: C#
•	Framework / Thư viện: .NET 9
•	Công cụ / IDE: Visual Studio Code 2022

3. NỘI DUNG ĐÃ THỰC HIỆN
3.1. Mục tiêu hệ thống
Hệ thống Quản lý công ty du lịch Văn Hóa Việt TP.HCM nhằm tin học hóa việc quản lý tình hình đăng ký tour du lịch của khách và thông tin các tour quảng cáo trên website công ty:
Quản lý thông tin Tour: Các tour mặc định xuất phát và kết thúc tại TP.HCM, ghi nhận nơi dừng chân, phương tiện di chuyển, điểm tham quan.
Quản lý Đăng ký Tour Đoàn: Nhóm > 12 người, chọn ngày đi bất kỳ, đón tại vị trí yêu cầu, đặt cọc trước (hủy tour mất cọc), nộp danh sách bảo hiểm (nếu có), thanh toán sau chuyến đi.
Quản lý Đăng ký Tour Lẻ: Nhóm < 12 người, đăng ký theo chuyến đi cố định, thanh toán 100% tiền vé ngay khi đăng ký, đón tại các điểm cố định.
Phân công & Tính lương HDV: Phân công HDV đảm bảo không trùng lịch; tính lương hàng tháng = Lương căn bản + Lương theo các tour thực hiện.
Khảo sát ý kiến: Gửi phiếu khảo sát lấy ý kiến khách hàng sau khi kết thúc tour để nâng cao chất lượng dịch vụ.
3.2. Yêu cầu hệ thống (Đầu vào - Xử lý - Xuất kết quả)
Nhóm nghiệp vụ	Đầu vào	Xử lý chính	Xuất kết quả
 
Quản lý Tour & Lịch trình	Thông tin tour (mã, tên, số ngày, số đêm, đơn giá), nơi dừng chân, phương tiện, điểm tham quan.	Lưu danh mục tour; thiết lập lộ trình chi tiết các nơi dừng chân, phương tiện và điểm tham quan; đăng tải quảng cáo.	Danh sách tour du lịch; chương trình tour chi tiết hiển thị trên website.
Đăng ký tour theo đoàn	Thông tin đoàn (> 12 người), ngày đi chọn, địa điểm đón, tiền cọc, danh sách bảo hiểm (nếu có).	Kiểm tra điều kiện số người (>12); lập phiếu đăng ký theo đoàn; ghi nhận tiền cọc; lưu danh sách bảo hiểm.	Phiếu đăng ký tour theo đoàn; biên nhận tiền đặt cọc; danh sách bảo hiểm du lịch.
Đăng ký tour theo chuyến (Khách lẻ)	Thông tin khách lẻ (< 12 người), chuyến đi cố định, điểm bán vé, điểm đón quy định, tiền vé.	Kiểm tra chỗ còn trống; lập phiếu đăng ký/vé tour lẻ; thu và xác nhận thanh toán tiền vé.	Vé tour / Phiếu đăng ký chuyến lẻ; biên nhận thanh toán.
Phân công & Tính lương HDV	Thông tin HDV, lịch chuyến/tour đoàn, lương căn bản, đơn giá thù lao tour.	Kiểm tra chống trùng lịch; phân công HDV (1 HDV chuyến lẻ, 1 hoặc nhiều HDV tour đoàn đông); tổng hợp lương.	Bảng phân công hướng dẫn viên; Bảng tính lương nhân viên hàng tháng.
Thanh toán	Số tiền còn lại của tour đoàn.	Quyết toán và thu kinh phí tour đoàn sau chuyến đi.	Hóa đơn thanh toán tour đoàn.
Khảo sát	Khảo sát và ý kiến góp ý của khách hàng.	Thu nhận và tổng hợp các góp ý khảo sát từ khách hàng.	Báo cáo tổng hợp ý kiến khảo sát.

3.3. Phân loại công việc theo mẫu phân tích
Bộ phận / Actor	Công việc	Loại	Quy định liên quan
 
Bộ phận Quản lý Tour / Website	Quản lý thông tin tour, điểm tham quan, nơi dừng chân và phương tiện.	Lưu trữ / Tra cứu	Tất cả tour xuất phát & kết thúc tại TP.HCM; công khai thông tin trên website.
Nhân viên Bán vé / Lễ tân	Đăng ký tour cho khách lẻ (theo chuyến).	Lưu trữ / Tính toán	Nhóm < 12 người; đi theo lịch cố định; chọn điểm đón quy định; thanh toán vé ngay.
Nhân viên Kinh doanh / CSKH	Lập phiếu đăng ký tour đoàn và lưu trữ thông tin KH.	Lưu trữ / Tra cứu	Nhóm > 12 người; chọn ngày đi bất kỳ; đón tại vị trí yêu cầu; đặt cọc trước (hủy mất cọc); thanh toán sau tour.
Bộ phận Điều hành	Phân công nhân viên hướng dẫn du lịch (HDV).	Lưu trữ / Tra cứu	Đảm bảo không chồng chéo lịch; chuyến lẻ 1 HDV, tour đoàn có thể nhiều HDV.
Bộ phận Kế toán	Thanh toán tiền tour đoàn và tính lương cho HDV.	Tính toán / Lưu trữ	Thu kinh phí sau tour đoàn; Lương HDV = Lương căn bản + Lương tour thực hiện.
Bộ phận Chăm sóc KH	Gửi phiếu khảo sát và ghi nhận ý kiến đóng góp.	Lưu trữ / Tổng hợp	Thực hiện sau khi kết thúc tour nhằm nâng cao chất lượng dịch vụ.

3.4. Quy tắc nghiệp vụ (Business Rules)
ID	Quy tắc nghiệp vụ
 
BR01	Tất cả các tour du lịch của công ty đều mặc định xuất phát và kết thúc tại TP.HCM.
BR02	Khách hàng đăng ký trên 12 người được tính là khách theo đoàn, chọn ngày đi bất kỳ và địa điểm đón yêu cầu.
BR03	Khách đăng ký theo đoàn phải đặt cọc trước; nếu không đi sẽ bị mất khoản tiền cọc này.
BR04	Kinh phí tham quan của khách theo đoàn sẽ thanh toán sau khi kết thúc chuyến tham quan.
BR05	Đoàn có mua bảo hiểm du lịch bắt buộc phải nộp kèm danh sách chi tiết các thành viên cùng đi.
BR06	Khách dưới 12 người là khách lẻ, đăng ký theo chuyến đi cố định theo lịch của công ty.
BR07	Khách lẻ thanh toán toàn bộ tiền vé ngay khi đăng ký và đón tour tại điểm quy định.
BR08	Phân công lịch làm việc cho HDV đảm bảo tuyệt đối không trùng/chồng chéo lịch giữa các tour/chuyến.
BR09	Mỗi chuyến khách lẻ phân công 1 HDV; tour đoàn đi đông có thể phân công nhiều HDV.
BR10	Lương hàng tháng của HDV = Lương căn bản + Tổng thù lao các tour đã thực hiện trong tháng.

3.5. Yêu cầu chức năng và phi chức năng
Bảng 1: Yêu cầu chức năng hệ thống
STT	Chức năng hệ thống	Mô tả
 
1	Kiểm tra dữ liệu	Không để trống khóa chính/trường bắt buộc (mã tour, mã đoàn, mã HDV); kiểm tra số người >0, số ngày/đêm hợp lệ, phân loại đúng số lượng khách đoàn (>12 người) hoặc khách lẻ (<12 người).
2	Transaction	Lập phiếu đăng ký, ghi nhận cọc, thanh toán vé lẻ, quyết toán kinh phí, phân công HDV không để cập nhật dở dang.
3	Thông báo trạng thái	Mọi thao tác phải báo thành công hoặc hiển thị rõ nguyên nhân từ chối (trùng lịch HDV, hết chỗ...).
4	Tra cứu quan hệ	ComboBox cho khóa ngoại, DataGridView cho danh sách tour, lộ trình dừng chân, điểm tham quan, danh sách bảo hiểm.
5	Ngăn thao tác rủi ro	Khóa mã khi sửa; ràng buộc khóa ngoại (FK) chặn xóa dữ liệu đã phát sinh nghiệp vụ.

Bảng 2: Yêu cầu phi chức năng
Tiêu chuẩn	Yêu cầu
 
Tiện dụng	Bố cục giao diện thiết kế chuẩn quy trình nghiệp vụ; tên control nhất quán; thao tác chính gần dữ liệu liên quan.
Hiệu quả	Truy vấn có điều kiện; chỉ tải dữ liệu cần dùng; dùng transaction khi cập nhật nhiều bảng.
Tiến hóa	Tách mô hình 3 lớp (UI - Service - Data) để dễ nâng cấp quy định tính lương hoặc khuyến mãi.
Tương thích	Visual Studio 2022, .NET Framework 4.7.2, SQL Server LocalDB/Express, ADO.NET.

3.6. Danh sách Use Case Hệ Thống
STT	Mã Use Case	Tên Use Case	Tác nhân liên quan
 
1	UC01	Tra cứu / Xem thông tin Tour	Khách đoàn, Khách lẻ
2	UC02	Đăng ký Tour theo đoàn	Khách đoàn, NV Kinh Doanh / CSKH
3	UC03	Đăng ký Tour theo chuyến (Vé lẻ)	Khách lẻ, NV Bán vé / Lễ tân
4	UC04	Phân công Hướng dẫn viên	NV Điều Hành, Hướng Dẫn Viên
5	UC05	Thanh toán & Quyết toán Tour	Kế toán, Khách đoàn, Khách lẻ
6	UC06	Tính lương Hướng dẫn viên	Kế toán, Hướng Dẫn Viên
7	UC07	Gửi & Tiếp nhận phiếu khảo sát	Khách đoàn, Khách lẻ, NV CSKH
8	UC08	Quản lý Danh mục Tour & Lộ trình	Quản lý / Admin

4. KẾT QUẢ ĐẠT ĐƯỢC
Hoàn thành thiết kế đầy đủ các mô hình UML: Class Diagram, Use Case Diagram tổng quát & phân rã, Activity Diagram quy trình đăng ký tour, Sequence Diagram nghiệp vụ lập phiếu đăng ký tour đoàn.
Xây dựng giao diện Form C# Windows Forms frmLapPhieuDangKyTourDoan hỗ trợ lập phiếu đăng ký tour đoàn đầy đủ các trường dữ liệu và ràng buộc nghiệp vụ.

5. LỖI GẶP PHẢI & CÁCH KHẮC PHỤC
STT	Lỗi gặp phải	Nguyên nhân	Cách khắc phục
 
1	…	…	…
2	…	…	….


