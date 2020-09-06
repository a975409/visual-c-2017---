using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F2C_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtTemp.MaxLength = 3;
            TxtTemp.TabIndex = 0;
            TxtAns.ReadOnly = true;
        }

        private void BtnFtoC_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(TxtTemp.Text);
            double c = (f - 32) * 5 / 9;

            TxtAns.Text = "攝氏" + c.ToString("f2") + "度";
            TxtTemp.Focus();
        }

        private void BtnCtoF_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(TxtTemp.Text);
            double f = c * 9 / 5 + 32;

            TxtAns.Text = "華氏" + f.ToString("f2") + "度";
            TxtTemp.Focus();
        }
    }
}
