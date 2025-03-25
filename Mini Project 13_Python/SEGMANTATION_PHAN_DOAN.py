import cv2      # Sử dụng thư viện xử lý ảnh Opencv
from PIL import Image  # Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np # Thuật toán xử lý ma trận

# Khai báo đường dẫn file hình
filehinh = r'E:\Machine Vision\XLA_01FIE\lena_color.png'

# Đọc ảnh màu dùng thư viện Opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PILLOW (Ảnh PIL dùng để thực hiện các tác vụ xử lý  và tính toán thay vì dùng Opencv)
imgPIL = Image.open(filehinh)

# Tạo các kênh màu có cùng kích thước và mode
SegImg = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
w = imgPIL.size[0] # Chiều dài ảnh
h = imgPIL.size[1] # Chiều ngang ảnh

#khai báo giá trị xy và ngưỡng
X1= 80
X2=150
Y1=400
Y2= 500
Nguong=45
Gs = 0
Rs = 0
Bs = 0

# Dùng vòng lặp for để quét các điểm ảnh
for x in range(X1,X2):
    for y in range(Y1,Y2):
        R,G,B=imgPIL.getpixel((x,y))
        Rs += R
        Gs += G
        Bs += B

S= (X2-X1+1)*(Y2-Y1+1)
Rs= Rs /S
Gs= Gs /S
Bs= Bs /S

for x in range (w):
    for y in range(h):
        R1,G1,B1=imgPIL.getpixel((x,y))
        D = np.sqrt((R1 - Rs)**2 + (G1 - Gs)**2 + (B1 - Bs)**2)
        if D <Nguong:
            SegImg.putpixel((x,y),(255,255,255))
        else:
            SegImg.putpixel((x,y),(B1,G1,R1))

# Chuyển ảnh từ PIL sang Opencv
AnhSeg = np.array(SegImg)

# Hiển thị ảnh dùng thư viện opencv
cv2.imshow('Hinh phan doan mau X1=8 X2=150 Y1=400 Y2 500', AnhSeg)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho cửa sổ
cv2.destroyAllWindows()