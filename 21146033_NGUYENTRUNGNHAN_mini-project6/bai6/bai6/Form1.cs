using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Load hình .jpg từ file

            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");

            // Cho hiển thị trên pictureBox 
            picBoxHinhGoc.Image = HinhGoc;

            // Hiển thị các kênh màu CMYK được chuyển đổi từ RGB
            //Gọi hàm chuyển đổi RGB sang CMYK


            List<Bitmap> CMYK = ChuyenDoiRGBSangCMYK(HinhGoc);

            //Hàm trên trả về 4 màu tương ứng thứ tự 0-3 là CMYK

            picBoxKenhMauCyan.Image = CMYK[0];           //Kênh màu Cyan
            picBoxKenhMauMagenta.Image = CMYK[1];        //Kênh màu Magenta
            picBoxKenhMauYellow.Image = CMYK[2];         //Kênh màu Yellow
            picBoxKenhMauBlack.Image = CMYK[3];          //Kênh màu Black
        }

        public List<Bitmap> ChuyenDoiRGBSangCMYK(Bitmap hinhgoc)

        {
            // Màu Cyan (xanh dương) là kết hợp giữa Green và Blue , set kênh Red
            //Màu Magenta(tím) là  kết hợp giữa Red và Blue , set kênh Green
            //Màu Yellow(vàng) là  kết hợp giữa Red và Green , set kênh Blue
            //Màu Black(đen) là  lấy MIN(R,G,B)



            // Tạo 1 list để chứa 4 kênh ảnh tương ứng CMYK
            //c#.Net kiểu List là 1 mảng nhưng ko cần phải khai báo trước


            List<Bitmap> CMYK = new List<Bitmap>();

            // Tạo 4 hình bitmap, kích thước 4 khung bằng với kích thước gốc để chuyển đổi kênh màu đc thực hiện đúng từng pixel
            //Mỗi kênh trong ko gian màu CMYK được hiển thị bởi 1 hình bitmap


            Bitmap Cyan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Magenta = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Yellow = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Black = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Dùng 2 vòng for quét pixel của hình gốc


            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh . Tại mỗi điểm ảnh sẽ tiến hành lấy thông tin 
                    //Do là ảnh gốc RGB nên mỗi pixel sẽ chứa thông tin của 3 kênh màu 

                    Color pixel = hinhgoc.GetPixel(x, y);
                    //Mỗi kênh màu đc biểu diễn 8 bit , tương ứng 1 byte 
                    //Dùng kiểu dữ liệu byte để chứa thông tin từng kênh màu

                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Trộn các kênh màu RGB để cho ra CYMK

                    // Màu Cyan (xanh dương) là kết hợp giữa Green và Blue , set kênh Red=0
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));

                    //Màu Magenta(tím) là  kết hợp giữa Red và Blue , set kênh Green=0
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));

                    //Màu Yellow(vàng) là  kết hợp giữa Red và Green , set kênh Blue=0
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));

                    //Màu Black(đen) là  lấy MIN(R,G,B)
                    //Hàm MIN chỉ có 2 đầu vào nên phải thực hiện 2 lần

                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));
                }

            //Add các hình ảnh tương ứng các kênh màu CMYK vào list
            //List là kiểu dữ liệu mảng (Array) ko cần bít kích thước nên có thể Add các element 
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);

            // Hàm trả về là 1 list 4 ảnh bitmap tương ứng 4 kênh màu CMYK 
            return CMYK;
        }
    }
}

