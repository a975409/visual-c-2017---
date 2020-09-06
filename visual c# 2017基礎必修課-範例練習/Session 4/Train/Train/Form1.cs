using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "票價：";
            TxtKm.TabIndex = 0;
            RdbKind1.Checked = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int km = Convert.ToInt32(TxtKm.Text);
                double money;

                if(RdbKind1.Checked)
                {
                    money = km * 2.27;
                }
                else if(RdbKind2.Checked)
                {
                    money = km * 1.75;
                }
                else
                {
                    money = km * 1.46;
                }

                if (ChkSpecial.Checked)
                    money /= 2;

                if (ChkToBack.Checked)
                    money = money * 2 * 0.9;

                LblMsg.Text = "票價：" + money.ToString("f2") + "元";
            }
            catch
            {
                MessageBox.Show("請輸入公里數");
                TxtKm.Clear();
                TxtKm.Focus();
            }
        }
    }
}
