# Ứng dụng mô phỏng các thuật toán mã hóa

## Giới thiệu

Repository này chứa mã nguồn của một ứng dụng WinForms dùng minh họa nhiều kỹ thuật mã hóa và bảo mật như 3DES, RC4, RSA, ký số RSA, OCR hình ảnh và hệ thống đăng nhập kèm OTP. Dự án được phát triển trên .NET Framework 4.7.2.

## Cấu trúc thư mục

- **CodeMaHoa** – Thư viện hiện thực các thuật toán 3DES (`3DES.cs`), RC4 (`RC4Cipher.cs`), RSA (`RSACipher.cs`).
- **FormThuatToan** – Các form giao diện thao tác với từng thuật toán (mã hóa/giải mã 3DES, RC4, RSA).
- **DigitalSignature** – Chức năng tạo và xác thực chữ ký số bằng RSA. Bao gồm lớp `RSADigitalSignarute` và form `frm_RSADigitalSignature`.
- **Models** – Mô hình dữ liệu Entity Framework (`DBContext.cs`, `Users.cs`).
- **Resources** – Chứa ảnh giao diện minh họa (login, register…).
- **Login.cs / FormUser.cs** – Đăng nhập, đăng ký người dùng với OTP, menu truy cập tới các chức năng.
- **DocAnhAI.cs** – Tính năng OCR và thử nghiệm RSA trên hình ảnh.
- **App.config** – Thiết lập cấu hình ứng dụng và chuỗi kết nối cơ sở dữ liệu.

## Yêu cầu cài đặt

1. **.NET Framework 4.7.2** (hoặc mới hơn).
2. Khôi phục các gói NuGet: `EntityFramework`, `Tesseract`, `System.Speech`.
3. Thiết lập chuỗi kết nối cơ sở dữ liệu trong `App.config` cho phù hợp môi trường của bạn (các mục `connectionStrings`).

## Build và chạy

1. Mở giải pháp `3DES.sln` bằng Visual Studio.
2. Chọn **Restore NuGet Packages** để tải các thư viện phụ thuộc.
3. Build solution và chạy ứng dụng (F5).

## Sử dụng

- **Đăng ký**: Người dùng nhập thông tin và xác thực OTP gửi qua email để tạo tài khoản.
- **Đăng nhập**: Điền tên tài khoản, mật khẩu đã mã hóa bằng 3DES trong CSDL. Có chức năng quên mật khẩu bằng OTP.
- **Thuật toán**:
  - **3DES** – Form `frm_3DESCipher` cho phép mã hóa/giải mã chuỗi.
  - **RC4** – Form `frm_RC4` thao tác với RC4.
  - **RSA** – Form `frm_RSACipher` tạo khóa, mã hóa/giải mã.
- **Chữ ký số**: Form `frm_RSADigitalSignature` hỗ trợ tạo/kiểm tra chữ ký cho file, lưu/đọc public key và gửi email đính kèm.
- **OCR hình ảnh**: Form `DocAnhAI` cho phép tải ảnh, nhận dạng text (thư viện Tesseract) và một số thao tác mã hóa.

Ảnh minh họa nằm trong thư mục `Resources` có thể được dùng để bổ sung cho hướng dẫn sử dụng.

