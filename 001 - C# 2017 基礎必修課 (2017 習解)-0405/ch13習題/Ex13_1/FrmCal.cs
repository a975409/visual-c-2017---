using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13_1
{
    public partial class FrmCal : Form
    {
        public FrmCal()
        {
            InitializeComponent();
        }

        public static int n1, n2;

        private void FrmCal_Load(object sender, EventArgs e)
        {
            label1.Text = "第一個數值：" + n1.ToString();
            label2.Text = "第二個數值：" + n2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = n1.ToString() + " + " + n2.ToString() + " = " + (n1 + n2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = n1.ToString() + " - " + n2.ToString() + " = " + (n1 - n2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = n1.ToString() + " * " + n2.ToString() + " = " + (n1 * n2).ToString();
            }
            catch
            {
                MessageBox.Show("無法運算");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = n1.ToString() + " / " + n2.ToString() + " = " + (n1 / n2).ToString();
            }
            catch
            {
                MessageBox.Show("無法運算");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
