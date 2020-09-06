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
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private static int n2 = 0;

        public int getNum2()
        {
            return n2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                n2 = 0;
            }

            this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n2 = 0;
            this.Hide();
            this.Dispose();
        }
    }
}
