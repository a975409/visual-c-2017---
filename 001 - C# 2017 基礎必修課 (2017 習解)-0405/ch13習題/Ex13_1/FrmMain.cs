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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int n1, n2;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Frm1 f1 = new Frm1();
            Frm2 f2 = new Frm2();

            f1.ShowDialog();
            n1 = f1.getNum1();
            f2.ShowDialog();
            n2 = f2.getNum2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCal f = new FrmCal();
            FrmCal.n1 = n1;
            FrmCal.n2 = n2;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
