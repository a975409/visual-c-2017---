using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string[] tea = new string[] { "丁曉雯", "羅文聰", "陳盈潔", "左安安", "許景醇" };
        int n;
        int[] score = new int[5];

        private void Form1_Load(object sender, EventArgs e)
        {
            n = 0;
            LblScore.Text = tea[n] + "老師給分";
            LblMsg.Text = "";
            BtnReset.Click += Form1_Load;
            BtnOK.Enabled = true;
            TxtScore.TabIndex = 0;
            TxtScore.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                score[n] = Convert.ToInt32(TxtScore.Text);

                if(score[n]<0 || score[n]>100)
                {
                    MessageBox.Show("請輸入範圍0~100的分數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtScore.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("請輸入數值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtScore.Focus();
                return;
            }

            LblMsg.Text += tea[n] + "老師給分：" + score[n] + "\n";
            n++;

            if (n>=5)
            {
                double score_sum = 0;

                foreach(int a in score)
                {
                    score_sum += a;
                }

                LblMsg.Text += "===============\n";
                LblMsg.Text += "平均分數：" + (score_sum / 5).ToString("f2");

                BtnOK.Enabled = false;
                return;
            }
            else
            {
                LblScore.Text = tea[n] + "老師給分";
            }

            TxtScore.Focus();
        }

        private void TxtScore_Enter(object sender, EventArgs e)
        {
            TxtScore.Clear();
        }
    }
}
