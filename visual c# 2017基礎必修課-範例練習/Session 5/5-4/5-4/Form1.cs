using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_4
{
    public partial class Form1 : Form
    {
        int rxdollor;
        int cost;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtLast.ReadOnly = true;
            Txt_Num_1.ReadOnly = true;
            Txt_Num_10.ReadOnly = true;
            Txt_Num_100.ReadOnly = true;
            Txt_Num_1000.ReadOnly = true;
            Txt_Num_5.ReadOnly = true;
            Txt_Num_50.ReadOnly = true;
            Txt_Num_500.ReadOnly = true;

            TxtRxdollor.TabIndex = 0;
            TxtCost.TabIndex = 1;
            BtnOK.TabIndex = 2;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                rxdollor = Convert.ToInt32(TxtRxdollor.Text);
            }
            catch
            {
                MessageBox.Show("請輸入收現金額", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtRxdollor.Focus();
                return;
            }
                
            try
            {
                cost = Convert.ToInt32(TxtCost.Text);
            }
            catch
            {
                MessageBox.Show("請輸入消費金額", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCost.Focus();
                return;
            }

            int result = rxdollor - cost;
            TxtLast.Text = result + "元";

            if (result >= 0)
            {
                int Num_1000 = result / 1000;
                int Num_500 = result % 1000 / 500;
                int Num_100 = result % 500 / 100;
                int Num_50 = result % 100 / 50;
                int Num_10 = result % 50 / 10;
                int Num_5 = result % 10 / 5;
                int Num_1 = result % 5;

                Txt_Num_1.Text = Num_1.ToString();
                Txt_Num_10.Text = Num_10.ToString();
                Txt_Num_100.Text = Num_100.ToString();
                Txt_Num_1000.Text = Num_1000.ToString();
                Txt_Num_5.Text = Num_5.ToString();
                Txt_Num_50.Text = Num_50.ToString();
                Txt_Num_500.Text = Num_500.ToString();
            }
            else
                MessageBox.Show("收現金額不足", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void TxtRxdollor_Enter(object sender, EventArgs e)
        {
            TxtRxdollor.Clear();
        }

        private void TxtCost_Enter(object sender, EventArgs e)
        {
            TxtCost.Clear();
        }
    }
}
