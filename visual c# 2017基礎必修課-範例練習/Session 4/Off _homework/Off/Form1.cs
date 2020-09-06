using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Off
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
                int buy = Convert.ToInt32(TxtBuy.Text);
                int pay = 0;

                if(buy<=1000)
                {
                    pay = Convert.ToInt32(buy * 0.95);
                }

                if (buy > 1000)
                {
                    pay = Convert.ToInt32(buy * 0.9);
                }

                LblPay.Text = "實付金額：" + pay.ToString("C0") + "元";
            }
            catch
            {
                MessageBox.Show("請輸入金額", "注意");
            }
        }
    }
}
