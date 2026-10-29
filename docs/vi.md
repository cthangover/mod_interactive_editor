# Trình sửa tương tác — vật thể bấm được trên phông nền của cảnh

Trình sửa tương tác sửa các vật thể bấm được của `interactive_base` — cửa, rương, đèn, vùng nóng vô hình — ngay trên phông nền mà chúng thuộc về. Bạn đặt và chỉnh hình vùng va chạm của từng vật thể bằng chuột, rồi điền sprite, lớp, con trỏ và lệnh khi nhấp.

## Cách mở

Nút búa trên thanh công cụ trong trò chơi → **Trình sửa tương tác**.

## Sửa vật thể

![Trình sửa tương tác với tệp graveyard_interactives.json của cthangover_game: các vật thể crypt_spot và book_wipe, vùng va chạm chữ nhật của crypt_spot được chọn cùng tay nắm, bên phải thuộc tính: lớp foreground, con trỏ PointingHand, vùng va chạm, làm nổi bật và hành động kịch bản.](assets/interactive-editor.jpg)

1. Chọn mod và tệp tương tác (`interactives/*.json`). **Đối tượng trong tệp** liệt kê các vật thể; **+ Mới**, **Nhân bản** và **Xóa đối tượng** thay đổi danh sách.
2. Bản xem trước hiện phông nền của cảnh có kịch bản thêm vật thể đó (trình sửa tìm trong các kịch bản); **Phông nền xem trước** chọn phông khác.
3. Bấm vào vùng va chạm để chọn và kéo tay nắm của nó. **Hình dạng** là hình chữ nhật, hình tròn hoặc đa giác; ở chế độ đa giác, bấm lên nền để thêm đỉnh, chuột phải vào đỉnh để xóa (ít nhất ba đỉnh).
4. **Thuộc tính**: **ID**, **Texture** (để trống là vùng bấm vô hình), **Lớp**, **Thứ tự Z**, **Con trỏ**, **Bật**, **Hiển thị** và **Lệnh khi nhấp (mỗi dòng một lệnh)**. **Làm nổi bật** (**Màu**, **Tỉ lệ**) đặt cách vật thể sáng lên và phóng to dưới con trỏ. Trong **Hành động**, **Kịch bản** là tệp `.scenario` chạy khi nhấp, còn **Khi rê chuột vào** / **Khi rê chuột ra** chứa lệnh chạy khi con trỏ đi vào hoặc rời đi.
5. Ctrl+S lưu tệp. ID trùng hoặc trống bị từ chối kèm thông báo.

Tệp đã lưu là dữ liệu mod bình thường. Trò chơi đang chạy nhận nó qua tải lại nóng mod (tự động sau khi lưu, hoặc Ctrl+Shift+R), và vật thể xuất hiện khi kịch bản thêm chúng vào cảnh.

## Phụ thuộc

`tools_base`, `scenario_tools_base`, `interactive_base`, `ui_base`.
Gói cũ `editor_tools` cài mod này cùng các cửa sổ tác giả khác.
