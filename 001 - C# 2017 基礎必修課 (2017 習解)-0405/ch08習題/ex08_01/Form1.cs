using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] defPic = new PictureBox[4];//PictureBox控制項陣列
        private void Form1_Load(object sender, EventArgs e)
        {
            defPic[0] = Pic1; defPic[1] = Pic2;//指定控制項陣列元素值
            defPic[2] = Pic3; defPic[3] = Pic4;
            for (int i = 0; i < defPic.Length; i++)
            {   //圖片調整成控制項大小
                defPic[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int[] pc = new int[4];//整數陣列存放亂數值
            Random rnd = new Random();
            for (int i = 0; i < defPic.Length; i++) //for迴圈0-3
            {
                pc[i] = rnd.Next(0, 10);    //產生0-9亂數
                //顯示亂數對應的圖檔
                defPic[i].Image = new Bitmap(pc[i].ToString() + ".gif");
            }
        }
    }
}
