using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            picBoxHinhGoc.Image = HinhGoc;
            List<Bitmap> XYZ= ChuyenDoiRGBSangXYZ(HinhGoc);
            Button.Click += Button_Click;
        }
        public List<Bitmap> ChuyenDoiRGBSangXYZ(Bitmap hinhgoc)
        {
            List<Bitmap> XYZ = new List<Bitmap>();
            Bitmap KX = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap KY = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap KZ = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap imgXYZ = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double X = (R * 0.4124564 + G * 0.3575761 + B * 0.1804375);
                    double Y = (R * 0.2126729 + G * 0.7151522 + B * 0.0721750);
                    double Z = (R * 0.0193339 + G * 0.1191920 + B * 0.9503041);

                    KX.SetPixel(x, y, Color.FromArgb((byte)(X), (byte)(X), (byte)(X)));
                    KY.SetPixel(x, y, Color.FromArgb((byte)(Y), (byte)(Y), (byte)(Y)));
                    KZ.SetPixel(x, y, Color.FromArgb((byte)(Z), (byte)(Z), (byte)(Z)));
                    imgXYZ.SetPixel(x, y, Color.FromArgb((byte)(X), (byte)(Y), (byte)(Z)));
                }
            XYZ.Add(KX);
            XYZ.Add(KY);
            XYZ.Add(KZ);
            XYZ.Add(imgXYZ);
            return XYZ;
        }
            private void Button_Click(object sender, EventArgs e)
            {
            Bitmap HinhGoc = new Bitmap(@"D:\XLA\lena_color.png");
            picBoxHinhGoc.Image = HinhGoc;
            List<Bitmap> XYZ = ChuyenDoiRGBSangXYZ(HinhGoc);
            picBoxKenhX.Image = XYZ[0];
            picBoxKenhY.Image = XYZ[1];
            picBoxKenhZ.Image = XYZ[2];
            picBoxKenhXYZ.Image = XYZ[3];

        }    
    }
}    

