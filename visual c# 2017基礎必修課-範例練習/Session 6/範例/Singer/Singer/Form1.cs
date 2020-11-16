using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string[] singers = new string[] { "曾佩慈", "田馥甄", "A-Lin", "楊丞琳", "蔡依林", "彭佳慧" };
        string[] Cbosingers = new string[] { "曾佩慈", "田馥甄", "A-Lin", "楊丞琳", "蔡依林", "彭佳慧" };
        string[] msg = new string[] { "我是曾佩慈 ---福茂唱片", "日常 ---華研", "罪惡感 ---索尼", "年輪說 ---環球", "Play 我呸 ---華納", "大齡女子 ---金澤大風" };
        int[] Vots = new int[singers.Count()];

        private void Form1_Load(object sender, EventArgs e)
        {
            LstVote.Items.Clear();
            foreach(string s in Cbosingers)
            {
                if(!CboSinger.Items.Contains(s))
                {
                    CboSinger.Items.Add(s);
                }
            }
            
            for(int i=0;i<singers.Count();i++)
            {
                LstVote.Items.Add(singers[i] + "\t" + Vots[i] + "票");
            }
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            int selectindex = CboSinger.SelectedIndex;

            if(selectindex>=0)
            {
                string singer = CboSinger.Text;
                int index = Array.IndexOf(singers, singer);
                //LstVote.Items.RemoveAt(index);
                //Vots[index] += 1;
                //string result = singers[index] + "\t" + Vots[index] + "票";
                //LstVote.Items.Insert(index, result);
                Vots[index] += 1;
                Array.Sort(Vots, singers);
                Array.Reverse(Vots);
                Array.Reverse(singers);

                Form1_Load(sender, e);
            }
        }

        private void CboSinger_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectindex = CboSinger.SelectedIndex;
            LblMsg.Text = msg[selectindex];
        }
    }
}
