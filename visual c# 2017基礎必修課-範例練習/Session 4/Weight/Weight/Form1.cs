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
            RdbMan.Checked = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(TxtHeight.Text);
                double weight;

                if(RdbMan.Checked)
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

            }
        }
    }
}
