using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtHeight.Text = "160";
            TxtHeight.TabIndex = 0;
            RdbMan.Checked = true;
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(TxtHeight.Text);
                double weight;

                if (RdbMan.Checked)
                {
                    weight = (height - 80) * 0.7;
                }
                else
                {
                    weight = (height - 70) * 0.6;
                }
                LblMsg.Text = "標準體重：" + weight.ToString("f1") + "公斤";
            }
            catch
            {
                MessageBox.Show("身高請輸入性別", "注意");
                TxtHeight.Clear();
                TxtHeight.Focus();
            }
        }

        private void RdbMan_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbMan.Checked)
                TxtHeight_TextChanged(sender, e);
        }

        private void RdbWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbWoman.Checked)
                TxtHeight_TextChanged(sender, e);
        }
    }
}
