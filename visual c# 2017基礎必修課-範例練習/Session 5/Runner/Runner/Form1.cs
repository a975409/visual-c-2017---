using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        private void Form1_Load(object sender, EventArgs e)
        {
            num = 0;
            PicRun.SizeMode = PictureBoxSizeMode.StretchImage;
            TmrRun.Interval = 200;
            TmrRun.Enabled = true;
            TmrMove.Interval = 100;
            BtnRun.Image = ImgButton.Images[0];
            BtnStop.Image = ImgButton.Images[1];
        }

        private void TmrRun_Tick(object sender, EventArgs e)
        {
            PicRun.Image = ImgRun.Images[num];

            if (num == 3)
                num = 0;
            else
                num++;
        }

        private void TmrMove_Tick(object sender, EventArgs e)
        {
            PicRun.Left -= 10;

            if (PicRun.Left <= -45)
                PicRun.Left = ClientSize.Width;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            TmrMove.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrMove.Stop();
        }
    }
}
