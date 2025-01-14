## Mini Project 2
import cv2 as cv    # Sử dụng thư viện xử lý ảnh OpenCV cho python
import numpy as np  # thư viện toán học, tính toán ma trận

# Đọc ảnh màu dùng thư viện OpenCV
img = cv.imread('E:\Machine Vision\XLA_01FIE\lena_color.png')
# Lấy kích thước ảnh
height = len(img[0])
width = len(img[1])
# Khai báo 3 biến chứ hình 3 kênh R-G-B
red = np.zeros((width, height, 3), np.uint8) # 3 là 3 kênh màu R-G-B, mỗi kênh 8 bit
green = np.zeros((width, height, 3), np.uint8)
blue = np.zeros((width, height, 3), np.uint8)
# Ban đầu set zero cho tất cả các điểm ảnh cả 3 kênh trong mỗi hình
red[:] = [0, 0, 0]
green[:] = [0, 0, 0]
blue[:] = [0, 0, 0]

# Mỗi hình là 1 ma trận 2 chiều nên sẽ dùng 2 vòng for
# để đọc hết các điểm ảnh (pixel) có trong hình
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R = img[x, y, 2]
        G = img[x, y, 1]
        B = img[x, y, 0]

        # Thiết lập màu cho các kênh
        red[x, y, 2] = R
        green[x, y, 1] = G
        blue[x, y, 0] = B


# Hiển thị hình dùng OpenCV
cv.imshow('Original', img)
cv.imshow('Blue', blue)
cv.imshow('Green', green)
cv.imshow('Red', red)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey(0)
# Giải phóng bộ nhớ đã cấp phát cho hiển thị hình
cv.destroyAllWindows()