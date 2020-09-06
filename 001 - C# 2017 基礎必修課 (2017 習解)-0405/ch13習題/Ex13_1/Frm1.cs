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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private static int n1 = 0;

        public int getNum1()
        {
            return n1;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                n1 = 0;
            }

            this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = 0;
            this.Hide();
            this.Dispose();
        }
    }
}
