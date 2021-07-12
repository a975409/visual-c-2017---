using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblResponMsg.Text = "請選擇你要的冷飲";
            //Console.WriteLine("第一個Windows Form程式");
            //Console.WriteLine("小數位數：pi={0:F5}", 3.1415926);
            //Console.WriteLine("百分比：{0:p}", 0.865);
            //Console.WriteLine("金融符號：{0:C}", 100000000);
            //Console.WriteLine("科學記號：{0:E}", 0.000000000000000015615);

            //Console.WriteLine("現在時間：{0}", DateTime.Now);
            //Console.WriteLine("{0:d}", DateTime.Now);
            //Console.WriteLine("{0:D}", DateTime.Now);
            //Console.WriteLine("{0:F}", DateTime.Now);
            //Console.WriteLine("{0:T}", DateTime.Now);
            //Console.WriteLine("{0:t}", DateTime.Now);
            //Console.WriteLine("{0:M}", DateTime.Now);

            //MessageBox.Show("歡迎使用本程式!!","歡迎",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnBlackTea_Click(object sender, EventArgs e)
        {
            LblResponMsg.Text = "您選了紅茶25元";
        }

        private void BtnGreenTea_Click(object sender, EventArgs e)
        {
            LblResponMsg.Text = "您選了綠茶25元";
        }

        private void BtnMilkTea_Click(object sender, EventArgs e)
        {
            LblResponMsg.Text = "您選了奶茶40元";
        }

        private void BtnCoke_Click(object sender, EventArgs e)
        {
            LblResponMsg.Text = "您選了可樂35元";
        }
    }
}
