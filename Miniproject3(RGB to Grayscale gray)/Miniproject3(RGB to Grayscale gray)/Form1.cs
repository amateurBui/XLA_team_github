using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Miniproject3_RGB_to_Grayscale_gray_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Project3: Nguyen Trung Nhan - 21146033
            InitializeComponent();
            //Load hinh .jpg tu file anh
            //them @ vao truoc duong dan c# theo chuoi unicode
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            //Emgu.CV.Image<Bgr, byte> img = new Emgu.CV.Image<Bgr, byte>(HinhGoc);
            //Hen thi ra man hinh anh GOC
            picBox_AnhGoc.Image = HinhGoc;
            //Hien thi img mau xam bang pp Average
            picBox_Average.Image = ppAverage(HinhGoc);
            //Hien thi img mau xam bang pp Lightness
            picBox_Lightress.Image = ppLightness(HinhGoc);
            //Hien thi img mau xam bang pp Luminance
            picBox_Luminance.Image = ppLuminance(HinhGoc);
        }

        public Bitmap ppAverage(Bitmap HinhGoc)
        {
            
            Bitmap GreyScalePicture = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Chuong trinh quet lay cac diem anh
            for (int x = 0; x < HinhGoc.Width;x++)
                for (int y = 0; y < HinhGoc.Height;y++)
                {
                    //Doc cac gia tri diem anh tai (x, y)
                    Color pixel = HinhGoc.GetPixel(x, y);
                    //Doc gia tri R, G, B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //sau khi lay duoc cac gia tri mau thi tien hinh tinh gia tri gray
                    byte grey = (byte)((R + G + B)/3);
                    //set cac gia tri mau grey vao 
                    GreyScalePicture.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }

            return GreyScalePicture;
            
        }
        //phuong phap lightness
        public Bitmap ppLightness(Bitmap HinhGoc)
        {

            Bitmap GreyScalePicture = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Chuong trinh quet lay cac diem anh
            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Doc cac gia tri diem anh tai (x, y)
                    Color pixel = HinhGoc.GetPixel(x, y);
                    //Doc gia tri R, G, B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //sau khi lay duoc cac gia tri mau thi tien hinh tinh gia tri gray
                    //tinh gia tri Max va Min khi ap dung phuong phap Lightness
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, R));
                    byte grey = (byte)((max + min) / 2);
                    //set cac gia tri mau grey vao 
                    GreyScalePicture.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }

            return GreyScalePicture;

        }
        //Phuong phap Luminance
        public Bitmap ppLuminance(Bitmap HinhGoc)
        {

            Bitmap GreyScalePicture = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Chuong trinh quet lay cac diem anh
            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Doc cac gia tri diem anh tai (x, y)
                    Color pixel = HinhGoc.GetPixel(x, y);
                    //Doc gia tri R, G, B
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //sau khi lay duoc cac gia tri mau thi tien hinh tinh gia tri gray
                    //phuong nay co cong tinh chi can nhap vao la tinh
                    byte grey = (byte)(0.2126*R+0.7152*G+0.0722*B);
                    //set cac gia tri mau grey vao 
                    GreyScalePicture.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }

            return GreyScalePicture;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
