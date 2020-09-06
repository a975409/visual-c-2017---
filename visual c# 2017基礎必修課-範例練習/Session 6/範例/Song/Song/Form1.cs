using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Song
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] song = new string[] { "不為誰而做的歌", "餘波盪漾", "後來的我們", "不該", "年輪說", "滿座", "關鍵詞", "天真有邪", "獨善其身", "一次幸福的機會" };

        string[] singer = new string[] { "林俊傑", "田馥甄", "五月天", "周杰倫", "楊丞琳", "李榮浩", "林俊傑", "林宥嘉", "田馥甄", "蕭敬騰" };

        int[] no = new int[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<no.Length;i++)
            {
                no[i] = i + 1;
            }

            BtnSortNo_Click(sender, e);
        }

        private void BtnSortNo_Click(object sender, EventArgs e)
        {
            int[] no2 = new int[no.Length];
            no.CopyTo(no2, 0);

            Array.Sort(no, singer);
            Array.Sort(no2, song);
            DisplaySortList();
        }

        private void BtnSortSong_Click(object sender, EventArgs e)
        {
            string[] singer2 = new string[no.Length];

            singer.CopyTo(singer2, 0);

            Array.Sort(singer, no);
            Array.Sort(singer2, song);
            DisplaySortList();
        }

        private void DisplaySortList()
        {
            string msg = "排名\t歌手\t歌曲\r\n";

            for (int i = 0; i < no.Length; i++)
            {
                msg += no[i] + "\t" + singer[i] + "\t" + song[i] + "\r\n";
            }

            TxtMsg.Text = msg;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(singer, TxtSinger.Text);

            string msg = "排名\t歌手\t歌曲\r\n";
            if (index>=0)
            {
                do
                {
                    msg += no[index] + "\t" + singer[index] + "\t" + song[index] + "\r\n";
                    index = Array.IndexOf(singer, TxtSinger.Text, ++index);
                } while (index >= 0);
            }
            TxtMsg.Text = msg;
        }
    }
}
