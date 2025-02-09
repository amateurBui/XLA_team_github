using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            picBoxHinhGoc.Image = HinhGoc;
            List<Bitmap> YCrCb= ChuyenDoiRGBSangYCrCb(HinhGoc);
            Button.Click += Button_Click;
        }
        public List<Bitmap> ChuyenDoiRGBSangYCrCb(Bitmap hinhgoc)
        {
            List<Bitmap> YCrCb = new List<Bitmap>();
            Bitmap KY = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap KCr = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap KCb = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap imgYCrCb = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double Y = (16 + (65.738 * R / 256) + (129.057 * G / 256) + (25.064 * B / 256));
                    double Cr = (128 - (37.945 * R / 256) - (74.494 * G / 256) + (112.439 * B / 256));
                    double Cb = (128 + (112.439 * R / 256) - (94.154 * G / 256) - (18.285 * B / 256));

                    KY.SetPixel(x, y, Color.FromArgb((byte)(Y), (byte)(Y), (byte)(Y)));
                    KCr.SetPixel(x, y, Color.FromArgb((byte)(Cr), (byte)(Cr), (byte)(Cr)));
                    KCb.SetPixel(x, y, Color.FromArgb((byte)(Cb), (byte)(Cb), (byte)(Cb)));
                    imgYCrCb.SetPixel(x, y, Color.FromArgb((byte)(Y), (byte)(Cr), (byte)(Cb)));
                }
            YCrCb.Add(KY);
            YCrCb.Add(KCr);
            YCrCb.Add(KCb);
            YCrCb.Add(imgYCrCb);
            return YCrCb;
        }
            private void Button_Click(object sender, EventArgs e)
            {
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            picBoxHinhGoc.Image = HinhGoc;
            List<Bitmap> YCrCb = ChuyenDoiRGBSangYCrCb(HinhGoc);
            picBoxKenhY.Image = YCrCb[0];
            picBoxKenhCr.Image = YCrCb[1];
            picBoxKenhCb.Image = YCrCb[2];
            picBoxKenhYCrCb.Image = YCrCb[3];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}