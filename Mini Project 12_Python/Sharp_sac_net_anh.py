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
SharpImg = Image.new(imgPIL.mode, imgPIL.size)

# Ma trận thay thế để tính thay cho phương pháp laplician
matran = np.array([[0, -1, 0], [-1, 4, -1], [0, -1, 0]])

# Lấy kích thước của ảnh từ imgPIL
w = imgPIL.size[0] # Chiều dài ảnh
h = imgPIL.size[1] # Chiều ngang ảnh

# Mỗi ảnh là một ma trận 2 chiều nên dùng 2 vòng lặp for để đọc hết các điểm ảnh (pixel) có trong ảnh
# Tiến hành quét các điểm ảnh
for x in range(1, w-1):
    for y in range(1, h-1):
         # Lấy giá trị tại điểm (x, y)
        Rs = 0
        Gs = 0
        Bs = 0

         # Tiến hành quét các điểm trong mặt nạ
        for i in range (x-1,x+2):
            for j in range (y-1,y+2):
                # Lấy thông tin màu RGB tại điểm ảnh trong mặt nạ vị trí (i, j)
                R,G,B = imgPIL.getpixel((i, j))
                # Nhân tích chập cho tất cả các điểm ảnh của mỗi kênh R-G-B
                Rs += R*matran[j-y+1, i-x+1]
                Gs += G*matran[j-y+1, i-x+1]
                Bs += B*matran[j-y+1, i-x+1]
        # Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ thò tính điểm sắc nét mỗi kênh theo công thức 3.6-7
        R2,G2,B2 =imgPIL.getpixel((x,y)) 
        SharpR = R2 + Rs
        SharpG = G2 + Gs
        SharpB = B2 + Bs

        if (SharpR<0):
            SharpR=0
        elif (SharpR>255):
            SharpR = 255
        if (SharpG<0):
            SharpG=0
        elif (SharpG>255):
            SharpG = 255
        if (SharpB<0):
            SharpB=0
        elif (SharpB>255):
            SharpB = 255
        SharpImg.putpixel((x,y), (SharpB, SharpG, SharpR))

# Chuyển ảnh từ PIL sang Opencv
AnhSharp = np.array(SharpImg)

# Hiển thị ảnh dùng thư viện opencv
cv2.imshow('Hinh RGB goc co gai Lena', img)
cv2.imshow('Hinh lam net anh', AnhSharp)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho cửa sổ
cv2.destroyAllWindows()
