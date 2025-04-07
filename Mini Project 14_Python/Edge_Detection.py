import cv2      # Sử dụng thư viện xử lý ảnh Opencv
from PIL import Image  # Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np # Thuật toán xử lý ma trận

# Khai báo đường dẫn file hình
filehinh = r'E:\Machine Vision\XLA_01FIE\lena_color.png'

# Đọc ảnh màu dùng thư viện Opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PILLOW (Ảnh PIL dùng để thực hiện các tác vụ xử lý  và tính toán thay vì dùng Opencv)
imgPIL = Image.open(filehinh)

# Chuyển ảnh màu RGB sang ảnh mức xám dùng phương pháp Luminance
anhxam = Image.new(imgPIL.mode, imgPIL.size)
width = anhxam.size[0]
height = anhxam.size[1]
for x in range(width):
    for y in range(height):
        R, G, B = imgPIL.getpixel((x, y))            
        gray = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)
        anhxam.putpixel((x, y), (gray, gray, gray))

# Chọn ngưỡng so sánh
Nguong = 130
#############################################################################################################
# Nhận dạng đường biên sử dụng ma trận Sobel (Ma trận/mặt nạ Sobel theo phương x và y)
Sx = np.array([[-1, -2, -1], [0, 0, 0], [1, 2, 1]])
Sy = np.array([[-1, 0, 1], [-2, 0, 2], [-1, 0, 1]])
imageSobel = Image.new(anhxam.mode, anhxam.size)
for x in range(1, width - 1):
    for y in range(1, height - 1):
        gx = gy = 0
        # Quét các điểm ảnh nằm trong mặt nạt 3x3
        for i in range(x - 1, x + 2):
            for j in range(y - 1, y + 2):
                # Nhân tích chập
                gR, gG, gB = anhxam.getpixel((i, j))                
                gx += gR * Sx[j - y + 1, i - x +1]
                gy += gR * Sy[j - y + 1, i - x +1]
        # M(x, y): Độ lớn của gradient f(x, y) hay (gx, gy)
        M = np.abs(gx) + np.abs(gy)
        if M <= Nguong:
            imageSobel.putpixel((x, y), (0, 0, 0)) # Thuộc background
        else:
            imageSobel.putpixel((x, y), (255, 255, 255)) # Thuộc Edge
hinhSobel = np.array(imageSobel)


# Nhận dạng đường biên sử dụng ma trận Prewitt
Px = np.array([[-1, -1, -1], [0, 0, 0], [1, 1, 1]])
Py = np.array([[-1, 0, 1], [-1, 0, 1], [-1, 0, 1]])
imagePrewitt = Image.new(anhxam.mode, anhxam.size)
for x in range(1, width - 1):
    for y in range(1, height - 1):
        gx = gy = 0
        for i in range(x - 1, x + 2):
            for j in range(y - 1, y + 2):
                gR, gG, gB = anhxam.getpixel((i, j))                
                gx += gR * Px[j - y + 1, i - x +1]
                gy += gR * Py[j - y + 1, i - x +1]
        M = np.abs(gx) + np.abs(gy)
        if M <= Nguong:
            imagePrewitt.putpixel((x, y), (0, 0, 0)) # Thuộc background
        else:
            imagePrewitt.putpixel((x, y), (255, 255, 255)) # Thuộc Edge
hinhPrewitt = np.array(imagePrewitt)


# Nhận dạng đường biên sử dụng ma trận Robert (Ma trận/mặt nạ Robert theo phương x và y)
Rx = np.array([[-1, 0], [0, 1]])
Ry = np.array([[0, -1], [1, 0]])
imageRobert = Image.new(anhxam.mode, anhxam.size)
for x in range(0, width - 1):
    for y in range(0, height - 1):
        gx = gy = 0
        # Quét các điểm ảnh nằm trong mặt nạt 2x2
        for i in range(x, x + 2):
            for j in range(y, y + 2):
                # Nhân tích chập
                gR, gG, gB = anhxam.getpixel((i, j))                
                gx += gR * Rx[j - y, i - x]
                gy += gR * Ry[j - y, i - x]
        # M(x, y): Độ lớn của gradient f(x, y) hay (gx, gy)
        M = np.abs(gx) + np.abs(gy)
        if M <= Nguong:
            imageRobert.putpixel((x, y), (0, 0, 0)) # Thuộc background
        else:
            imageRobert.putpixel((x, y), (255, 255, 255)) # Thuộc Edge
hinhRobert = np.array(imageRobert)

# Hiển thị ảnh dùng thư viện opencv
cv2.imshow('Anh mau RGB goc', img)
cv2.imshow('Anh da duoc nhan dang duong bien Sobel:', hinhSobel)
cv2.imshow('Anh da duoc nhan dang duong bien Prewitt:', hinhPrewitt)
cv2.imshow('Anh da duoc nhan dang duong bien Robert:', hinhRobert)


# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho cửa sổ
cv2.destroyAllWindows()