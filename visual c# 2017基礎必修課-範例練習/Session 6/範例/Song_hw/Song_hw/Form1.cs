using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Song_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] song = new string[] { "林俊傑-不為誰而做的歌",
                                        "田馥甄-餘波盪漾",
                                        "五月天-後來的我們",
                                        "周杰倫-不該",
                                        "楊丞琳-年輪說",
                                        "李榮浩-滿座",
                                        "林俊傑-關鍵詞",
                                        "林宥嘉-天真有邪",
                                        "田馥甄-獨善其身",
                                        "蕭敬騰-一次幸福的機會" };
        int[] no;

        private void Form1_Load(object sender, EventArgs e)
        {
            no = new int[song.Length];

            for (int i = 0; i < no.Length; i++)
            {
                no[i] = i + 1;
            }
            BtnSortIncNo_Click(sender, e);
        }

        private void BtnSortIncNo_Click(object sender, EventArgs e)
        {
            Array.Sort(no, song);
            DisplaySortList();
        }

        private void DisplaySortList()
        {
            string msg = "排名\t歌手\t歌曲\r\n";
            for (int i = 0; i < no.Length; i++)
            {
                string[] temp = song[i].Split('-');

                msg += no[i] + "\t" + temp[0] + "\t" + temp[1] + "\r\n";
            }

            TxtMsg.Text = msg;
        }

        private void BtnSortDecNo_Click(object sender, EventArgs e)
        {
            Array.Sort(no, song);
            Array.Reverse(no);
            Array.Reverse(song);
            DisplaySortList();
        }

        private void BtnSortIncSong_Click(object sender, EventArgs e)
        {
            Array.Sort(no, song);
            DisplaySortList();
        }
    }
}
