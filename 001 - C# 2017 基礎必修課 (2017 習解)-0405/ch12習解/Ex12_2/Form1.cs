using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace Ex12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer player;
        String path;

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            String stFilter = "WAV(*.wav)|*.wav";
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            player = new SoundPlayer(path);
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            player.Load();                                 // 載入音效檔資料
            player.Play();
        }

        private void BtnLoop_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            player.Stop();　　　　　　　                 　 // 停止播放
        }

        private void BtnEnd_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
