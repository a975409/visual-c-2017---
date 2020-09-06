using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT_to_US
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RdbNTtoUS_CheckedChanged(object sender, EventArgs e)
        {
            if(RdbNTtoUS.Checked)
            {
                int dollor = 0;
                double rate = 0;
                double result = 0;
                string msg = "";
                try
                {
                    dollor = Convert.ToInt32(TxtDollor.Text);
                }
                catch
                {
                    MessageBox.Show("請輸入金額", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RdbNTtoUS.Checked = false;
                    TxtDollor.Focus();
                    return;
                }

                try
                {
                    rate = Convert.ToDouble(TxtRate.Text);
                }
                catch
                {
                    MessageBox.Show("請輸入美金匯率", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RdbNTtoUS.Checked = false;
                    TxtRate.Focus();
                    return;
                }

                result = dollor / rate;
                msg = "台幣" + dollor.ToString("f2") + "元可兌換成美金" + result.ToString("f2") + "元";
                LblMsg.Text = msg;
            }
        }

        private void RdbUStoNT_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUStoNT.Checked)
            {
                int dollor = 0;
                double rate = 0;
                double result = 0;
                string msg = "";
                try
                {
                    dollor = Convert.ToInt32(TxtDollor.Text);
                }
                catch
                {
                    MessageBox.Show("請輸入金額", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RdbUStoNT.Checked = false;
                    TxtDollor.Focus();
                    return;
                }

                try
                {
                    rate = Convert.ToDouble(TxtRate.Text);
                }
                catch
                {
                    MessageBox.Show("請輸入美金匯率", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RdbUStoNT.Checked = false;
                    TxtRate.Focus();
                    return;
                }

                result = dollor * rate;
                msg = "美金" + dollor.ToString("f2") + "元可兌換成台幣" + result.ToString("f2") + "元";
                LblMsg.Text = msg;
            }
        }

        private void TxtDollor_Enter(object sender, EventArgs e)
        {
            TxtDollor.Clear();
        }

        private void TxtRate_Enter(object sender, EventArgs e)
        {
            TxtRate.Clear();
        }
    }
}
