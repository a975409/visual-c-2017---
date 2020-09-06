using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex08_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] defPic = new PictureBox[6];//PictureBox控制項陣列

        // GetRnd方法可用來取得n~m之間的num個不重複的亂數，並傳給所設定的陣列
        private void GetRnd(ref int[] vArray, int min, int max, int num)
        {
            int max_dim, rem_num, choice;
            max_dim = max - min + 1;    //最小值到最大值的個數
            int[] t = new int[max_dim]; //建立一個t陣列，大小等於最小值到最大值的個數
            for (int i = 0; i < max_dim; i++)   //將最小值到最大值逐一寫入陣列
            {
                t[i] = min + i;
            }
            rem_num = max_dim - 1;  //亂數的最大值等於最小值到最大值的個數-1
            Random rnd = new Random();
            for (int i = 0; i < num; i++)   //逐一取num個亂數
            {
                choice = rnd.Next(rem_num + 1); //取得的亂數
                vArray[i] = t[choice];  //亂數存入陣列中
                for (int j = choice; j < rem_num; j++)  //將取得亂數之後的元素值向前移一個位置
                {
                    t[j] = t[j + 1];
                }
                rem_num -= 1;   //取亂數的最大值減一
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defPic[0] = Pic1; defPic[1] = Pic2; defPic[2] = Pic3;//指定控制項陣列值
            defPic[3] = Pic4; defPic[4] = Pic5; defPic[5] = Pic6;
            for (int i = 0; i < defPic.Length; i++)
            {
                defPic[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int[] pk = new int[6];
            //呼叫GetRnd最小值為1、最大值為42、取六個不重複的亂數到pk陣列
            GetRnd(ref pk, 1, 42, 6);   
            Array.Sort(pk);   //pk陣列排序
            for (int i = 0; i < defPic.Length; i++)
            {
                defPic[i].Image = new Bitmap(pk[i].ToString() + ".gif");
            }
        }
    }
}
