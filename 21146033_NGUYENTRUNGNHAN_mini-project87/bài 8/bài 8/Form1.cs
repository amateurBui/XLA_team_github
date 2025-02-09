using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            picBoxHinhGoc.Image = HinhGoc;
            List<Bitmap> HSV = ChuyenDoiRGBSangHSV(HinhGoc);


        }
        public List<Bitmap> ChuyenDoiRGBSangHSV(Bitmap hinhgoc)
        {
            List<Bitmap> HSV = new List<Bitmap>();
            Bitmap Hue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Saturation = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Value = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap HSVImg = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;


                    double t1 = ((R - G) + (R - B)) / 2;
                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B));
                    double theta = Math.Acos(t1 / t2);


                    double H = 0;
                    if (B <= G)
                        H = theta;
                    else
                        H = 2 * Math.PI - theta;
                    H = H * 180 / Math.PI;

                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);
                    double V = Math.Max(R, Math.Max(G, B));


                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S * 255), (byte)(S * 255), (Byte)(S * 255)));
                    Value.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (Byte)V));
                    HSVImg.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S * 255), (Byte)V));
                }
             HSV.Add(Hue);
             HSV.Add(Saturation);
             HSV.Add(Value);
             HSV.Add(HSVImg);
             return HSV;

    }        
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            picBoxHinhGoc.Image = HinhGoc;
            List<Bitmap> HSV = ChuyenDoiRGBSangHSV(HinhGoc);
            picBoxH.Image = HSV[0];
            picBoxS.Image = HSV[1];
            picBoxV.Image = HSV[2];
            picBoxHSV.Image = HSV[3];
        }
    }
}
   



