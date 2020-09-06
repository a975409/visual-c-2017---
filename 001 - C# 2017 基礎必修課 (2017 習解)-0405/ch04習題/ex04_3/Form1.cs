using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtMoney.Text = "0";
            TxtRate.Text = "31.5";
            RdbNT2US.Checked = true;
            LblMsg.Text = "請輸入金額和匯率後，再選擇換匯的類別。";
        }

        private void RdbNT2US_Click(object sender, EventArgs e)
        {
            try
            {
                double money = Convert.ToDouble(TxtMoney.Text);//取得輸入的金額
                double rate = Convert.ToDouble(TxtRate.Text);//取得輸入的美金匯率
                if (RdbNT2US.Checked)   //若選取台幣換美金
                    LblMsg.Text = "台幣" + money.ToString() + "元可兌換成美金" + (money / rate).ToString("N") + "元";
                else  //其餘即選取美金換台幣
                    LblMsg.Text = "美金" + money.ToString() + "元可兌換成台幣" + (money * rate).ToString("N") + "元";
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void RdbUS2NT_Click(object sender, EventArgs e)
        {
            try
            {
                double money = Convert.ToDouble(TxtMoney.Text);//取得輸入的金額
                double rate = Convert.ToDouble(TxtRate.Text);//取得輸入的美金匯率
                if (RdbNT2US.Checked)   //若選取台幣換美金
                    LblMsg.Text = "台幣" + money.ToString() + "元可兌換成美金" + (money / rate).ToString("N") + "元";
                else  //其餘即選取美金換台幣
                    LblMsg.Text = "美金" + money.ToString() + "元可兌換成台幣" + (money * rate).ToString("N") + "元";
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
