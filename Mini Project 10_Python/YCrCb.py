import cv2
import numpy as np

# Đọc ảnh đầu vào
input_image = cv2.imread('E:\Machine Vision\XLA_01FIE\lena_color.png')

# Lấy chiều cao và chiều rộng của ảnh
height, width, _ = input_image.shape

# Khởi tạo mảng YCrCb
ycrcb_image = np.zeros((height, width, 3), dtype=np.uint8)

# Chuyển đổi từ RGB sang YCrCb
for i in range(height):
    for j in range(width):
        R, G, B = input_image[i, j]
        Y = 16 + (65.738*R/256) + (129.057*G/256) + (25.064*B/256)
        Cb = 128 - (37.945*R/256) - (74.494*G/256) + (112.439*B/256)
        Cr = 128 + (112.439*R/256) - (94.154*G/256) - (18.285*B/256)
        ycrcb_image[i, j] = (Y, Cr, Cb)

# Hiển thị các kênh Y, Cr và Cb
Y, Cr, Cb = cv2.split(ycrcb_image)
cv2.imshow('Y Channel', Y)
cv2.imshow('Cr Channel', Cr)
cv2.imshow('Cb Channel', Cb)
cv2.imshow('YCrCb Image', ycrcb_image)

cv2.waitKey(0)
cv2.destroyAllWindows()