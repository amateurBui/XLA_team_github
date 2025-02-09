using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap HinhGoc;
        public Form1()
        {
            InitializeComponent();
            HinhGoc = new Bitmap(@"D:\XLA\XLA_team_github\bird_small.jpg");
            picBoxHinhGoc.Image = HinhGoc;
            picBoxHinhXamLightness.Image = ChuyenHinhRGBSangHinhXamLightness(HinhGoc);
            picBoxHinhXamAverage.Image = ChuyenHinhRGBSangHinhXamAverage(HinhGoc);
            picBoxHinhXamLuminance.Image = ChuyenHinhRGBSangHinhXamLuminance(HinhGoc);
            picBoxHinhNhiPhan.Image = ChuyenHinhRGBSangHinhNhiPhan(HinhGoc, 100);
        }
        /// <summary>
        /// Khai báo hàm tính toán mức xám theo phương pháp Lightness
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public Bitmap ChuyenHinhRGBSangHinhXamLightness(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);

                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return HinhMucXam;
        }

        /// <summary>
        /// Khai báo hàm tính toán mức xám theo phương pháp Average
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public Bitmap ChuyenHinhRGBSangHinhXamAverage(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)((R + G + B) / 3);

                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return HinhMucXam;
        }

        /// <summary>
        /// Khai báo hàm tính toán mức xám theo phương pháp Luminance
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        public Bitmap ChuyenHinhRGBSangHinhXamLuminance(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return HinhMucXam;
        }
        public Bitmap ChuyenHinhRGBSangHinhNhiPhan(Bitmap hinhgoc, byte nguong)
        {
            Bitmap HinhNhiPhan = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte nhiphan = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);
                    if (nhiphan < nguong)
                        nhiphan = 0;
                    else
                        nhiphan = 255;
                    HinhNhiPhan.SetPixel(x, y, Color.FromArgb(nhiphan, nhiphan, nhiphan));
                }
            return HinhNhiPhan;
        }

        private void vScrollBarHinhNhiPhan_ValueChanged(object sender, EventArgs e)
        {
            byte nguong = (byte)vScrollBarHinhNhiPhan.Value;
            lblNguong.Text = nguong.ToString();
            picBoxHinhNhiPhan.Image = ChuyenHinhRGBSangHinhNhiPhan(HinhGoc, nguong);
        }
    }
}