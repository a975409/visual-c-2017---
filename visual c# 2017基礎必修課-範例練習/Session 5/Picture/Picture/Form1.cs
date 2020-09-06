using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicDemo1.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDemo2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDemo3.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDemo4.SizeMode = PictureBoxSizeMode.StretchImage;

            PicDemo1.Image = new Bitmap("pic1.jpg");
            PicDemo2.Image = new Bitmap("pic2.jpg");
            PicDemo3.Image = new Bitmap("pic3.jpg");
            PicDemo4.Image = new Bitmap("pic4.jpg");

            PicShow.Image = PicDemo1.Image;

        }

        private void Stretch()
        {
            for(int h=0;h<=200;h+=10)
            {
                PicShow.Size = new Size(250, h);
                DateTime now = DateTime.Now;

                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 1);
                label1.Text = h.ToString() ;
                
            }

            //x = 28 + 250;
            //y = PicShow.Location.Y;
            //PicShow.Location = new Point(x, y);

            //for (int w=0;w<=250;w+=10)
            //{
            //    PicShow.Size = new Size(w, 200);
            //    PicShow.Location = new Point(x -= 10, y);

            //    DateTime now = DateTime.Now;

            //    do
            //    {
            //        Application.DoEvents();
            //    }while((DateTime.Now - now).TotalSeconds<0.1);
            //}
        }

        private void PicDemo1_Click(object sender, EventArgs e)
        {
           
            PicShow.Image = PicDemo1.Image;
            Stretch();
        }

        private void PicDemo2_Click(object sender, EventArgs e)
        {
           
            PicShow.Image = PicDemo2.Image;
            Stretch();
        }

        private void PicDemo3_Click(object sender, EventArgs e)
        {
            
            PicShow.Image = PicDemo3.Image;
            Stretch();
        }

        private void PicDemo4_Click(object sender, EventArgs e)
        {
            
            PicShow.Image = PicDemo4.Image;
            Stretch();
        }
    }
}
