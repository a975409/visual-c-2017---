using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "請輸入年所得後後確定鈕，\n電腦會算出繳稅金額！";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double money = Convert.ToDouble(TxtIncome.Text);  //取得年所得
                double tax = 0;  //預設所得稅為0
                if (money < 300000) //若年所得< 300000
                {
                    tax = 0;    //設所得稅為0
                }
                else if (money >= 300000 && money <= 600000)    //若年所得介於300000~600000
                {
                    tax = money * 0.03;    //設所得稅為年所得*0.03
                }
                else if (money > 600001 && money <= 900000)    //若年所得介於600001~900000
                {
                    tax = money * 0.06;    //設所得稅為年所得*0.06
                }
                else if (money > 900001 && money <= 1500000)    //若年所得介於900001~1500000
                {
                    tax = money * 0.12;    //設所得稅為年所得*0.12
                }
                else if (money > 1500001 && money <= 5000000)    //若年所得介於1500001~5000000
                {
                    tax = money * 0.2;    //設所得稅為年所得*0.2
                }
                else if (money > 5000000)    //若年所得> 5000000
                {
                    tax = money * 0.3;    //設所得稅為年所得*0.3
                }
                LblMsg.Text = "年所得" + money.ToString("C0") + "元，\n應繳所得稅" 
                    + tax.ToString("C0") + "元";
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
