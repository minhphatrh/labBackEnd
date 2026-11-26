# ASP.NET Core MVC – Website Bán Phim Trực Tuyến

**Sinh viên:** Trịnh Minh Phát  
**MSSV:** 31241022342  
**Công nghệ:** ASP.NET Core MVC – .NET 10  
**Cơ sở dữ liệu:** Microsoft SQL Server  
**Repository:** [labBackEnd](https://github.com/minhphatrh/labBackEnd)

---

## 1. Giới thiệu dự án

Đây là dự án xây dựng website bán phim trực tuyến được thực hiện trong khuôn khổ bài tập cá nhân môn Phát triển ứng dụng Thương mại điện tử.

Website được phát triển theo mô hình ASP.NET Core MVC, cho phép người dùng xem danh sách phim, tìm hiểu thông tin sản phẩm, thêm phim vào giỏ hàng và thực hiện đặt hàng trực tuyến.

Dự án sử dụng Entity Framework Core để quản lý dữ liệu và kết nối với hệ quản trị cơ sở dữ liệu Microsoft SQL Server.

## 2. Công nghệ sử dụng

| Công nghệ | Vai trò |
|---|---|
| C# | Ngôn ngữ lập trình chính |
| ASP.NET Core MVC | Xây dựng ứng dụng web |
| .NET 10 | Nền tảng phát triển |
| Entity Framework Core | ORM và quản lý dữ liệu |
| Microsoft SQL Server | Hệ quản trị cơ sở dữ liệu |
| HTML, CSS, JavaScript | Xây dựng giao diện |
| Bootstrap | Thiết kế giao diện responsive |
| Visual Studio Code | Môi trường lập trình |

## 3. Các chức năng chính

### 3.1. Quản lý phim
- Hiển thị danh sách phim.
- Thêm phim mới.
- Chỉnh sửa thông tin phim.
- Xem chi tiết phim.
- Xóa phim.
- Quản lý giá, xếp hạng, ngày phát hành và mô tả phim.

### 3.2. Quản lý thể loại
- Hiển thị danh sách thể loại.
- Thêm, sửa, xóa thể loại.
- Liên kết phim với thể loại tương ứng.

### 3.3. Quản lý hình ảnh
- Upload hình ảnh cho phim.
- Lưu đường dẫn hình ảnh.
- Hiển thị hình ảnh trên trang danh sách phim.
- Sử dụng hình ảnh mặc định khi cần thiết.

### 3.4. Giỏ hàng
- Thêm phim vào giỏ hàng.
- Tăng số lượng sản phẩm.
- Xóa sản phẩm khỏi giỏ hàng.
- Tự động tính tổng tiền đơn hàng.
- Hiển thị số lượng sản phẩm và tổng tiền.

### 3.5. Checkout và quản lý đơn hàng
- Nhập thông tin khách hàng.
- Kiểm tra dữ liệu đầu vào.
- Lưu thông tin giao hàng.
- Tạo hóa đơn và chi tiết hóa đơn.
- Hiển thị trang xác nhận sau khi đặt hàng thành công.

## 4. Cấu trúc dự án

```text
31241022342_TrinhMinhPhat/
│
├── Areas/
│   └── Identity/
│
├── Controllers/
│   ├── GenresController.cs
│   ├── HomeController.cs
│   └── MoviesController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Extension/
│   ├── EmailServiceNew.cs
│   └── SessionExtensions.cs
│
├── Migrations/
│
├── Models/
│   ├── Movie.cs
│   ├── Genre.cs
│   ├── HoaDon.cs
│   ├── ChiTietHoaDon.cs
│   └── ShippingDetail.cs
│
├── Validation/
│
├── Views/
│   ├── Genres/
│   ├── Home/
│   ├── Movies/
│   └── Shared/
│
├── wwwroot/
│   ├── css/
│   ├── images/
│   ├── js/
│   └── lib/
│
├── Program.cs
├── appsettings.example.json
├── .gitignore
└── 31241022342_TrinhMinhPhat.csproj
```

## 5. Hướng dẫn cài đặt và chạy dự án

### 5.1. Yêu cầu môi trường

- Windows 10 hoặc Windows 11.
- .NET 10 SDK.
- Visual Studio Code.
- SQL Server.
- Extension C# Dev Kit trong VS Code.

### 5.2. Clone source code

Mở Terminal và chạy:

```bash
git clone https://github.com/minhphatrh/labBackEnd.git
```

Di chuyển vào thư mục dự án:

```bash
cd labBackEnd/31241022342_TrinhMinhPhat
```

### 5.3. Cấu hình cơ sở dữ liệu

Tạo file `appsettings.json` từ file cấu hình mẫu `appsettings.example.json`.

Cập nhật chuỗi kết nối SQL Server theo thông tin máy chủ và cơ sở dữ liệu của người chạy dự án.

Không sử dụng hoặc công khai thông tin đăng nhập của người khác.

### 5.4. Khôi phục các thư viện

```bash
dotnet restore
```

### 5.5. Cập nhật cơ sở dữ liệu

```bash
dotnet ef database update
```

Lưu ý: Cần cài đặt công cụ Entity Framework Core CLI và cấu hình kết nối SQL Server trước khi thực hiện.

### 5.6. Chạy ứng dụng

```bash
dotnet run
```

Sau khi chạy thành công, mở địa chỉ localhost được hiển thị trong Terminal để truy cập website.

## 6. Cơ sở dữ liệu

Dự án sử dụng Entity Framework Core Code First và Migrations để quản lý cấu trúc cơ sở dữ liệu.

Các bảng dữ liệu chính:

- Movies: Lưu thông tin phim.
- Genres: Lưu thông tin thể loại phim.
- HoaDons: Lưu thông tin hóa đơn.
- ChiTietHoaDons: Lưu chi tiết sản phẩm trong hóa đơn.
- ShippingDetails: Lưu thông tin giao hàng.

## 7. Triển khai website

Dự án đã được thử nghiệm publish bằng lệnh:

```bash
dotnet publish -c Release -o ./publish
```

Nền tảng hosting được lựa chọn thử nghiệm là Somee.

Tuy nhiên, quá trình triển khai chưa hoàn tất do dung lượng lưu trữ của gói hosting miễn phí không đủ để tải lên và giải nén toàn bộ các tệp của ứng dụng. Website được tiếp tục kiểm tra và chạy trên môi trường local.

## 8. Hướng phát triển

- Hoàn thiện giao diện người dùng trên nhiều thiết bị.
- Bổ sung chức năng tìm kiếm và lọc phim.
- Hoàn thiện quy trình thanh toán trực tuyến.
- Bổ sung quản lý tài khoản và phân quyền người dùng.
- Tối ưu hiệu suất và triển khai trên hosting phù hợp.

---

**Tác giả:** Trịnh Minh Phát  
**MSSV:** 31241022342  
**Repository:** https://github.com/minhphatrh/labBackEnd