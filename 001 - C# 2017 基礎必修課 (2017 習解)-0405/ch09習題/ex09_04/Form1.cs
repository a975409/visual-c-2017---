using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drag = false;//紀錄是否可拖曳，預設不可拖曳
        int sX, sY;       //紀錄滑鼠按下時的座標值

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(Pic_Zoom);
            PicZoom.SizeMode = PictureBoxSizeMode.StretchImage;
            PicZoom.Image = Image.FromFile("水庫.jpg");
        }

        private void Pic_Zoom(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                PicZoom.Width += 5; PicZoom.Height += 5;
            }
            else
            {
                if (PicZoom.Height > 25)
                {
                    PicZoom.Width -= 5; PicZoom.Height -= 5;
                }
            }
        }

        private void PicZoom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //若是按滑鼠左鍵
            {
                drag = true;//設drag=true，表可拖曳
                sX = e.X; sY = e.Y;  //紀錄滑鼠的座標值
            }
        }

        private void PicZoom_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)      //若設drag=true
            {
                PicZoom.Left += e.X - sX;
                PicZoom.Top += e.Y - sY;
            }
        }

        private void PicZoom_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; //設drag=false，表不可拖曳
        }
    }
}
