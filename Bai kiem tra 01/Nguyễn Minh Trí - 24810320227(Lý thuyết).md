Phần I — Lý thuyết

1. Kiểu giá trị vs Kiểu tham chiếu (cơ chế lưu trữ)

• Kiểu giá trị (Value Types: struct, enum, các kiểu nguyên thủy int, bool, char...): Dữ liệu được lưu trực tiếp tại vị trí khai báo (thường ở vùng nhớ Stack). Khi gán hoặc truyền tham số, C# sẽ sao chép toàn bộ giá trị thực sự sang ô nhớ mới, giúp các bản sao hoạt động độc lập tuyệt đối.
• Kiểu tham chiếu (Reference Types: class, interface, delegate, string, array...): Biến chỉ chứa địa chỉ tham chiếu (con trỏ) trỏ tới đối tượng thực sự được cấp phát trên Managed Heap. Phép gán chỉ sao chép địa chỉ con trỏ, khiến nhiều biến có thể cùng quản lý một đối tượng. Vòng đời dữ liệu trên Heap được quản lý và dọn dẹp tự động bởi Garabage Collector (GC).

2. Thuộc tính init-only (C# 9/10) so với set thông thường

• Accessor init: Cho phép thiết lập giá trị cho thuộc tính đúng 1 lần trong quá trình khởi tạo đối tượng (thông qua Constructor hoặc Object Initializer). Sau khi hoàn tất khởi tạo, thuộc tính trở thành bất biến (Immutable) và không thể thay đổi ở các bước xử lý sau.
• Accessor set thông thường: Cho phép đọc/ghi và cập nhật lại giá trị thuộc tính linh hoạt tại bất kỳ thời điểm nào trong vòng đời của đối tượng.
• Kịch bản áp dụng: Thường được dùng khi thiết kế các DTO (Data Transfer Object), Record hoặc các đối tượng cấu hình nhằm đảm bảo tính bất biến của dữ liệu sau khởi tạo mà vẫn giữ được sự tiện lợi của cú pháp Object Initializer.

3. virtual vs override (đa hình)

• Phương thức virtual (ở lớp cơ sở): Cho phép phương thức có thể được định nghĩa lại ở các lớp dẫn xuất, đồng thời cung cấp sẵn một phần thân xử lý mặc định ở lớp cha.
• Phương thức override (ở lớp dẫn xuất): Được lớp con sử dụng để ghi đè và thay thế hoàn toàn triển khai mặc định của lớp cha bằng logic xử lý mới.
• Triển khai đa hình: Khi thực thi qua biến tham chiếu thuộc kiểu lớp cha nhưng trỏ đến thể hiện của lớp con, CLR sẽ dùng cơ chế phân phát động (dynamic dispatch / V-Table) tại Runtime để gọi đúng phương thức ghi đè ở lớp con.

4. Tại sao thành phần static không thể truy xuất qua một thể hiện

• Quản lý bộ nhớ ở cấp độ Lớp (Type-level): Các thành phần static thuộc về chính định nghĩa của Lớp (Metadata) và được lưu trữ ở vùng nhớ dùng chung, không gắn liền hay thuộc quyền sở hữu của bất kỳ đối tượng (instance) cụ thể nào tạo bởi toán tử new.
• Tránh nhầm lẫn ngữ nghĩa & Đảm bảo Type-safety: Việc bắt buộc gọi qua tên Lớp (ví dụ: ClassName.Method()) giúp làm rõ ý định rằng đây là dữ liệu/hành vi toàn cục. Trình biên dịch C# chủ động ngăn chặn việc gọi qua thể hiện (báo lỗi CS0176) nhằm hạn chế sự hiểu nhầm rằng phương thức đang thao tác trên trạng thái riêng của thể hiện đó.
