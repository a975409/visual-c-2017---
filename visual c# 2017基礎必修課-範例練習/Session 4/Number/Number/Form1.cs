using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtNum.TabIndex = 0;
            LblMsg.Text = "請輸入整數後按下確定紐，電腦會判斷是奇數還是偶數!";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(TxtNum.Text);
                string msg = "";

                if(num%2==0)
                {
                    msg = num + "是偶數";
                }
                else
                {
                    msg = num + "是奇數";
                }
                LblMsg.Text = msg;
            }
            catch
            {
                MessageBox.Show("請輸入數字", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtNum_Enter(object sender, EventArgs e)
        {
            TxtNum.Clear();
        }
    }
}
