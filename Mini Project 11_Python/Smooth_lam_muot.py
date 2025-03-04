import cv2                         # sử dụng thư viện xử lý ảnh OpenCV
from PIL import Image              # thư viện PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np                 # thư viện toán học
#khai báo đường dẫn file hình
filehinh = r"E:\Machine Vision\XLA_01FIE\lena_color.png"
#đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)
imgPIL = Image.open(filehinh)
#tạo 1 ảnh có cùng kích thước và mode với ảnh imgPIL ảnh này dùng để chứa kqua chuyển đổi RGB sang Grayscale
Smoothed3 = Image.new(imgPIL.mode,imgPIL.size)
Smoothed5 = Image.new(imgPIL.mode,imgPIL.size)
Smoothed7 = Image.new(imgPIL.mode,imgPIL.size)
Smoothed9 = Image.new(imgPIL.mode,imgPIL.size)
#lấy kích thước ảnh
w = imgPIL.size[0]
h = imgPIL.size[1]
#3x3
##mỗi ảnh là ma trận 2 chiều nên sẽ dùng 2 vòng for để đọc hết các điểm ảnh Pixel có trong ảnh
# Lưu ý với mặt nạ 3x3 để dễ lập trình cso thể bỏ qa các viền ngoài của ảnh do vậy mình chỉ quét từ x=1 đến y=width-1
#y=1 đến y=height-1
for x in range( 1, w - 1):
    for y in range( 1, h - 1):
     #lấy trị điểm ảnh tại (x, y)
     #các biến này dùng chứa gtri cộng dồn của các điểm ảnh
     #nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
         
        #Tiến hành quét các điểm trong mặt nạ
        for i in range(x - 1, x + 2):
            for j in range (y - 1,y + 2):

                    
            #lấy thông tin màu R-G-B tại điểm ảnh trong mặt nạ tại vị trí (i,j)
                R, G, B = imgPIL.getpixel((i, j))

                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
            
        #Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ thì mình
        #tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu B-G-R trog sách
        K = 3 * 3    
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)
        
        #Set điểm ảnh đã làm mượt (làm mờ) vào ảnh

        Smoothed3.putpixel((x,y),(Bs, Gs, Rs))
            
#5x5
for x in range( 2, w  -2):
    for y in range( 2, h -2 ):
     #Lấy trị điểm ảnh tại (x, y)
     #các biến này dùng chứa gtri cộng dồn của các điểm ảnh
     #nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
         
        #Tiến hành quét các điểm trong mặt nạ
        for i in range(x - 2, x + 3):
            for j in range (y - 2,y + 3):     
            #Lấy thông tin màu R-G-B tại điểm ảnh trong mặt nạ
            #tại vị trí (i,j)
                R, G, B = imgPIL.getpixel((i, j))

                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
            
        #Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ thì mình
        #Tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu B-G-R trog sách
          
        Rs = np.uint8(Rs / 25)
        Gs = np.uint8(Gs / 25)
        Bs = np.uint8(Bs / 25)
        #Set điểm ảnh đã làm mượt (làm mờ) vào ảnh
        Smoothed5.putpixel((x,y),(Bs, Gs, Rs))
        
#7x7
for x in range( 3, w - 3):
    for y in range( 3, h - 3):
     #lấy trị điểm ảnh tại (x, y)
     #các biến này dùng chứa gtri cộng dồn của các điểm ảnh
     #nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
         
        #Tiến hành quét các điểm trong mặt nạ
        for i in range(x - 3, x + 4):
            for j in range (y - 3,y + 4): 
            #lấy thông tin màu R-G-B tại điểm ảnh trong mặt nạ
            #tại vị trí (i,j)
                R, G, B = imgPIL.getpixel((i, j))

                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
            
        #Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ thì mình
        #tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu B-G-R trog sách
          
        Rs = np.uint8(Rs / 49)
        Gs = np.uint8(Gs / 49)
        Bs = np.uint8(Bs / 49)
        
        #Set điểm ảnh đã làm mượt (làm mờ) vào ảnh

        Smoothed7.putpixel((x,y),(Bs, Gs, Rs))

#9x9
for x in range( 4, w - 4):
    for y in range( 4, h - 4):
     #lấy trị điểm ảnh tại (x, y)
     #các biến này dùng chứa gtri cộng dồn của các điểm ảnh
     #nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
         
        #Tiến hành quét các điểm trong mặt nạ
        for i in range(x - 4, x + 5):
            for j in range (y - 4,y + 5):   
            #lấy thông tin màu R-G-B tại điểm ảnh trong mặt nạ
            #tại vị trí (i,j)
                R, G, B = imgPIL.getpixel((i, j))

                #Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                Rs += R
                Gs += G
                Bs += B
            
            #Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ thì mình
            #tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu B-G-R trog sách
          
        Rs = np.uint8(Rs / 81)
        Gs = np.uint8(Gs / 81)
        Bs = np.uint8(Bs / 81)
        
        #Set điểm ảnh đã làm mượt (làm mờ) vào ảnh

        Smoothed9.putpixel((x,y),(Bs, Gs, Rs))


# để hiển thị ảnh OpenCv ở đâu cũng hiển thị thì chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
anh3x3=np.array(Smoothed3)
anh5x5=np.array(Smoothed5)
anh7x7=np.array(Smoothed7)
anh9x9=np.array(Smoothed9)

#hiển thị ảnh dùng thư viện OpenCv
cv2.imshow('Anh mau RGB goc co gai lena', img)
cv2.imshow('Hinh lam muot 3x3', anh3x3)
cv2.imshow('Hinh lam muot 5x5', anh5x5)
cv2.imshow('Hinh lam muot 7x7', anh7x7)
cv2.imshow('Hinh lam muot 9x9', anh9x9)
#Bấmphím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)
#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()