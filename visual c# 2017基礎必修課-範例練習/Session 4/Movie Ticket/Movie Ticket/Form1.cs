using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtMsg.ReadOnly = true;
            TxtMsg.Text = "請輸入身高後按下查詢按鈕";
            TxtHeight.TabIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int height = 0;
                height = Convert.ToInt32(TxtHeight.Text);
                string msg = "";

                if(height>=150)
                {
                    msg = "需購買成人票!";
                }
                else if(height>=115 && height<150)
                {
                    msg = "需購買孩童票!";
                }
                else
                {
                    msg = "不需購票!";
                }

                TxtMsg.Text = msg;
            }
            catch
            {
                TxtMsg.Text = "請輸入身高!!!";
                TxtHeight.Clear();
                TxtHeight.Focus();
            }
        }
    }
}
