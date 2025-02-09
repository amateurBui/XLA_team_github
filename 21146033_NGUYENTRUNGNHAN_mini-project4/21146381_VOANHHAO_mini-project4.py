import cv2
from PIL import Image
import numpy as np
filehinh = r'C:\Users\Admin\Downloads\download20230703104859.png'
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)
imgPIL = Image.open(filehinh)
binary = Image.new(imgPIL.mode, imgPIL.size)
width = binary.size[0]
height = binary.size[1]
Nguong = 130
for x in range(width):
    for y in range(height):
        pixel_values = imgPIL.getpixel((x, y))
        R = pixel_values[0]
        G = pixel_values[1]
        B = pixel_values[2]
        gray = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)
        if (gray < Nguong):
            binary.putpixel((x, y), (0, 0, 0))
        else:
            binary.putpixel((x, y), (255, 255, 255))
nhiphan = np.array(binary)
cv2.imshow('Anh mau RGB goc', img)
cv2.imshow('Anh nhi phan (Binary)', nhiphan)
cv2.waitKey(0)
cv2.destroyAllWindows()