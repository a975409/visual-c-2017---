using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ex12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;       //檔案路徑與檔名
        SoundPlayer player;    //宣告播放器物件

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicFU1_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "柳橙";
            TxtEng.Text = "orange";
            player = new SoundPlayer("fruit1.wav");
            player.Load();
            player.Play();
        }

        private void PicFU2_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "芒果";
            TxtEng.Text = "mango";
            player = new SoundPlayer("fruit2.wav");
            player.Load();
            player.Play();
        }

        private void PicFU3_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "番茄";
            TxtEng.Text = "tomato";
            player = new SoundPlayer("fruit3.wav");
            player.Load();
            player.Play();
        }

        private void PicFU4_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "草莓";
            TxtEng.Text = "strawberry";
            player = new SoundPlayer("fruit4.wav");
            player.Load();
            player.Play();
        }

        private void PicFU5_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "蘋果";
            TxtEng.Text = "apple";
            player = new SoundPlayer("fruit5.wav");
            player.Load();
            player.Play();
        }

        private void PicFU6_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "香蕉";
            TxtEng.Text = "banana";
            player = new SoundPlayer("fruit6.wav");
            player.Load();
            player.Play();
        }

        private void PicFU7_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "西瓜";
            TxtEng.Text = "watermelon";
            player = new SoundPlayer("fruit7.wav");
            player.Load();
            player.Play();
        }

        private void PicFU8_Click(object sender, EventArgs e)
        {
            TxtChi.Text = "洋梨";
            TxtEng.Text = "pear";
            player = new SoundPlayer("fruit8.wav");
            player.Load();
            player.Play();
        }
    }
}
