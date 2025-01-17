import cv2                      # Sử dụng thư viện xử lý ảnh OpenCV
from PIL import Image           # Thư viện xử lý ảnh PILLOW
import numpy as np              # Thư viện toán học, ma trận
import matplotlib.pyplot as plt #Thư viện vẽ biểu đồ

#================================================================
# Thuật toán chuyển đổi màu RGB sang ảnh mức xám (Grayscale)
# dùng phương pháp Luminance
#================================================================


def ChuyenDoiAnhMauRGBSangAnhXamLuminance(imgPIL):
    # Tạo một ảnh có cùng kích thước và mode với ảnh imgPIL
    # Ảnh này dùng để chứa kq chuyển đổi RGB sang Grayscale
    average = Image.new(imgPIL.mode, imgPIL.size)

    # Lấy kích thước ảnh từ imgPIL

    width = average.size[0]
    height = average.size[1]

    # Mỗi ảnh là một ma trận 2 chiều nên sẽ dùng 2 vòng for để
    # đọc hết các điểm ảnh (pixel) có trong ảnh
    for x in range(width):
        for y in range(height):
            R, G, B = imgPIL.getpixel((x,y))

            # Công thức chuyển đổi điểm ảnh màu RGB thành
            # Điểm ảnh mức xám dùng phương pháp Luminance
            gray = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)

            # Gán giá trị mức xám vừa tính cho ảnh
            average.putpixel((x,y), (gray, gray, gray))

    return average
#================================================================
# End ChuyenDoiAnhMauRGBSangAnhXamLuminance(HỉnhGB)
#================================================================

#================================================================
# Tính histogram của ảnh xám
#================================================================
def TinhHistogram(HinhXamPIL):
    # Mỗi pixel có giá trị từ 0-255, nên phải khai báo 1 mảng có
    # 256 phần tử để chứa số đếm của các pixels có cùng giá trị
    his = np.zeros(256)

    # Kích thước ảnh
    w = HinhXamPIL.size[0]
    h = HinhXamPIL.size[1]
    for x in range(w):
        for y in range(h):
            # Lấy giá trị xám tại (x, y)
            gR, gG, gB = HinhXamPIL.getpixel((x, y))

            # Giá trị gray tính ra cũng chính là phần tử thứ gray
            # trong mảng his đã khai báo ở trên, sẽ tăng số đếm
            # của phần tử thứ gray lên 1
            his[gR] += 1

    return his
#================================================================
# End: TinhHistogram(HĩnhamPIL)
#================================================================

#================================================================
# Vẽ biểu đồ Histogram dùng thư viện matplotlib
#================================================================
def VeBieuDoHistogram(his):
    w = 5
    h = 4
    plt.figure('Biểu đồ His xám', figsize=(((w, h))), dpi = 100)
    trucX = np.zeros(256)
    trucX = np.linspace(0, 256, 256)
    plt.plot(trucX, his, color = 'orange')
    plt.title('Biểu đồ histogram')
    plt.xlabel('Giá trị mức xám')
    plt.ylabel('Số điểm cùng giá trị mức xám')
    plt.show()
#================================================================
# End: VeBieuDoHistogram(his)
#================================================================

#================================================================
#------- Begin: CHƯƠNG TRÌNH CHÍNH ---------
#Lưu ý: Các hàm con phải khai báo trước khi chương trình chính gọi
#================================================================
# Khai báo đường dẫn file hình
filehinh = r'bird_small.jpg'

# Đọc ảnh dùng thư viện PIL
imgPIL = Image.open(filehinh)

# Chuyển sang ảnh mức xám
HinhXamPIL = ChuyenDoiAnhMauRGBSangAnhXamLuminance(imgPIL)

# Tính Histogram
his = TinhHistogram(HinhXamPIL)

# Chuyển ảnh PIL sang OpenCV để hiển thị bằng thư viện cv2
HinhXamCV = np.array(HinhXamPIL)
cv2.imshow('Anh muc xam', HinhXamCV)

# Hiển thị biểu đồ Histogram
VeBieuDoHistogram(his)

# Bấm phím bất kỳ để đóng các cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()

#================================================================
#-------- End: CHƯƠNG TRÌNH CHÍNH --------
#================================================================
