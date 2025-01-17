# Grayscale_binary
import cv2 # Sử dụng thư viện xử lý ảnh OpenCV
from PIL import Image # Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạnh ảnh
import numpy as np # Thue viện toán học, đặc biệt tính toán ma trận

# Khai báo đường dẫn
filehinh = r'lena_color.png'

# Đọc ảnh màu dùng OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu bằng thư viện PIL. Ảnh PIL ta sẽ dùng
# để thực hiện các tác vụ xử lý & tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)

# Tạo một ảnh có cùng kích thước và mode với ảnh imgPIL
# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Binary
binary = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
width = binary.size[0]
height = binary.size[1]
# Thiết lập ngưỡng
Nguong = 120

# Mỗi ảnh là 1 ma trận 2 chiều nên dùng 2 vòng for
# đọc hết các điểm ảnh (pixel) có trong ảnh
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R, G, B = imgPIL.getpixel((x, y))

        # Công thức chuyển đổi điểm ảnh màu RGB thành
        # điểm ảnh mức xám dùng phương pháp Luminance
        gray = np.uint8(0.2126*R+0.7152*G+0.0722*B)

        # Xác định giá trị điểm nhị phân
        if (gray < Nguong):
            binary.putpixel((x, y), (0,0,0))
        else:
            binary.putpixel((x, y), (255,255,255))

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
nhiphan = np.array(binary)

# Hiển thị ảnh dùng thư viện OpenCV
cv2.imshow('Original img', img)
cv2.imshow('Binary img', nhiphan)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()
