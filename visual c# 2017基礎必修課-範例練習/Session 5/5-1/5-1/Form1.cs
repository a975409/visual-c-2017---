using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(TxtNum.Text);
                int sum = 0;
                string msg = "1到" + num + "被7整除的數：\n";

                if(num>7 && num<100)
                {
                    for(int i=1;i<num;i++)
                    {
                        if(i>=7 && i%7==0)
                        {
                            msg += i + "\n";
                            sum += i;
                        }
                    }

                    msg += "------------\n" + "總和等於" + sum;
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show("請輸入大於7小於100的正整數", "錯誤");
                    TxtNum.Focus();
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字", "錯誤");
                TxtNum.Focus();
            }
        }

        private void TxtNum_Enter(object sender, EventArgs e)
        {
            TxtNum.Clear();
        }
    }
}
