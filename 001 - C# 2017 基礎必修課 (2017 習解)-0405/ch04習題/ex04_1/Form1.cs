using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "請輸入整數後按確定鈕，\n電腦會判斷是奇數還是偶數！";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(TxtInput.Text);  //取得輸入的整數
                if(num % 2 == 0)  //若num除以2的餘數為0時
                    LblMsg.Text = num.ToString() + " 是偶數";
                else  //其餘即除以2的餘數為1
                    LblMsg.Text = num.ToString() + " 是奇數";
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
