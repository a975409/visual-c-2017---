using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txtdollor.TabIndex = 0;
            LblMsg.Text = "請輸入年所得後按下確定鍵，電腦會計算出繳稅金額!";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int dollor = Convert.ToInt32(Txtdollor.Text);
                double tax = 0;
                string msg = "";

                if(dollor<300000)
                {
                    tax = 0;
                }
                else if(dollor>=300000 && dollor<600000)
                {
                    tax = dollor * 0.03;
                }
                else if (dollor >= 600000 && dollor < 900000)
                {
                    tax = dollor * 0.06;
                }
                else if (dollor >= 900000 && dollor < 1500000)
                {
                    tax = dollor * 0.12;
                }
                else if (dollor >= 1500000 && dollor < 5000000)
                {
                    tax = dollor * 0.2;
                }
                else 
                {
                    tax = dollor * 0.3;
                }
                msg = "年所得" + dollor.ToString("C") + "\n應繳所得稅" + tax.ToString("C2");
                LblMsg.Text = msg;
            }
            catch
            {
                MessageBox.Show("請輸入數值");
                Txtdollor.Focus();
            }
        }

        private void Txtdollor_Enter(object sender, EventArgs e)
        {
            Txtdollor.Clear();
        }
    }
}
