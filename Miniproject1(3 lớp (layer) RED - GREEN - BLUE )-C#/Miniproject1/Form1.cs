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

namespace Miniproject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string filehinh = (@"D:\XLA\lena_color.png");
            //Tao mot bien chua hinh bitmap duoc load tu file hinh tren
            Bitmap hinhgoc = new Bitmap(filehinh);
            //Hien thi hinh goc trong picBox da tao
            HienThiHinh.Image = hinhgoc;
            //Khai boa ba hinh bitmap de chua ba hinh RED, GREEN, BLUE
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Moi hinh la mot ma tran diem anh nen dung 2 vong lap for de doc het cac diem pixel trong anh
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height;y++)
                //doc cac gia tri pixel tai cac diem gia tri (x, y)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    //moi pixel chua 4 gia tri mau RED, GREEN, BLUE va thogn tin cac gia tri mau RGB
                    Byte R = pixel.R; //Gia tri kenh mau do
                    Byte G = pixel.G; //Gia tri kenh mau xanh la cay
                    Byte B = pixel.B; //Gia tri kenh mau xanh nuoc bien
                    Byte A = pixel.A; //Gia tri do trong suot
                    //Set gia tri pixel doc duoc chua cac mau RGB
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));
                }
            picBox_BLUE.Image = blue;
            picBox_RED.Image = red;
            picBox_GREEN.Image = green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HienThiHinh_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
