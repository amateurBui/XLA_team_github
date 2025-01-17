## Mini Project 2
import cv2 as cv    # Sử dụng thư viện xử lý ảnh OpenCV cho python
import numpy as np  # thư viện toán học, tính toán ma trận

# Đọc ảnh màu dùng thư viện OpenCV
img = cv.imread('E:\Machine Vision\XLA_01FIE\lena_color.png')
blank = np.zeros(img.shape[:2], dtype='uint8')

b,g,r = cv.split(img)
blue = cv.merge([b,blank, blank]) ## 3 ma trận
green = cv.merge([blank, g, blank])
red = cv.merge([blank,blank,r])

# Hiển thị hình dùng OpenCV
cv.imshow('Original', img)
cv.imshow('Blue', blue)
cv.imshow('Green', green)
cv.imshow('Red', red)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey(0)
# Giải phóng bộ nhớ đã cấp phát cho hiển thị hình
cv.destroyAllWindows()