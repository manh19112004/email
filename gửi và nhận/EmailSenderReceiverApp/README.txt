==============================
EmailSenderReceiverApp - C# WinForms
==============================

📦 Chức năng:
-------------
- Gửi email sử dụng Gmail (SMTP)
- Nhận email mới nhất bằng IMAP từ Gmail
- Nhập tài khoản và mật khẩu ứng dụng trong form
- Giao diện đơn giản dễ dùng

🧩 Yêu cầu:
----------
- Visual Studio 2022 hoặc mới hơn
- .NET 6 SDK (hoặc cao hơn)
- Gói NuGet: MailKit

🛠 Cài đặt & chạy:
------------------
1. Mở file 'EmailSenderReceiverApp.sln' bằng Visual Studio
2. Cài đặt thư viện MailKit:
   - Vào menu Tools > NuGet Package Manager > Package Manager Console
   - Chạy lệnh:
     Install-Package MailKit
3. Bấm Start (F5) để chạy chương trình

🔐 Gmail cần:
--------------
- Mật khẩu ứng dụng (App Password), KHÔNG dùng mật khẩu chính
  ➤ https://myaccount.google.com/apppasswords

📝 Sử dụng:
-----------
1. Nhập email & mật khẩu ứng dụng
2. Nhập địa chỉ người nhận, tiêu đề và nội dung
3. Bấm nút "Gửi" để gửi email
4. Bấm nút "Nhận Email" để lấy email mới nhất (hiển thị tiêu đề trong danh sách)

📩 Hỗ trợ mở rộng:
------------------
- Gửi file đính kèm
- Xem nội dung email chi tiết
- Giao diện đẹp hơn (theo phong cách Gmail)

Liên hệ nếu bạn cần hỗ trợ mở rộng thêm.