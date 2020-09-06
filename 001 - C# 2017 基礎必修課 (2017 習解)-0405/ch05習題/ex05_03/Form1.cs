using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //按向上鈕時
        private void BtnUp_Click(object sender, EventArgs e)
        {
            PicUfo.Top -= 10;   //PicUfo的Y座標上移10點
            //PicUfo的Y座標小於PicUfo的高度，即移出表單上界時
            if (PicUfo.Top <= -PicUfo.Height)   
            {
                //設PicUfo的Y座標等於表單工作區的高度，即由下方重新移入
                PicUfo.Top = this.ClientSize.Height;
            }
        }
        //按向下鈕時
        private void BtnDown_Click(object sender, EventArgs e)
        {
            PicUfo.Top += 10;   //PicUfo的Y座標上移10點
            //PicUfo的Y座標大於表單工作區的高度，即移出表單下界時
            if (PicUfo.Top >= this.ClientSize.Height)
            {
                //設PicUfo的Y座標等於-PicUfo的高度，即由上方重新移入
                PicUfo.Top = -PicUfo.Height;
            }
        }
        //按向左鈕時
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            PicUfo.Left -= 10;   //PicUfo的X座標左移10點
            //PicUfo的X座標小於PicUfo的寬度，即移出表單左界時
            if (PicUfo.Left <= -PicUfo.Width)
            {
                //設PicUfo的X座標等於表單工作區的寬度，即由右方重新移入
                PicUfo.Left = this.ClientSize.Width;
            }
        }
        //按向右鈕時
        private void BtnRight_Click(object sender, EventArgs e)
        {
            PicUfo.Left += 10;   //PicUfo的X座標右移10點
            //PicUfo的X座標大於表單工作區的寬度，即移出表單右界時
            if (PicUfo.Left >= this.ClientSize.Width)
            {
                PicUfo.Left = -PicUfo.Width;
            }
        }
        //按放大鈕時
        private void BtnLarge_Click(object sender, EventArgs e)
        {
            if (PicUfo.Width < 200) //若PicUfo的寬度小於200時
            {
                PicUfo.Width += 10;     //寬度加10點
                PicUfo.Height += 10;    //高度加10點
                PicUfo.Top -= 5;        //XY座標各減5點，以保持中心點位置不變
                PicUfo.Left -= 5;
            }
        }
        //按縮小鈕時
        private void BtnSmall_Click(object sender, EventArgs e)
        {
            if (PicUfo.Width > 10)  //若PicUfo的寬度大於10時
            {
                PicUfo.Width -= 10;     //寬度減10點
                PicUfo.Height -= 10;    //高度減10點
                PicUfo.Top += 5;        //XY座標各加5點，以保持中心點位置不變
                PicUfo.Left += 5;
            }
        }
    }
}
