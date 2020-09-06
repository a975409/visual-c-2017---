using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBC1_Click(object sender, EventArgs e)
        {
            LblWord.BackColor = Color.Black;
        }

        private void BtnBC2_Click(object sender, EventArgs e)
        {
            LblWord.BackColor = Color.Yellow;
        }

        private void BtnFC1_Click(object sender, EventArgs e)
        {
            LblWord.ForeColor = Color.Red;
        }

        private void BtnFC2_Click(object sender, EventArgs e)
        {
            LblWord.ForeColor = Color.Blue;
        }

        private void BtnFS1_Click(object sender, EventArgs e)
        {
            LblWord.Font = new Font("標楷體", 36, FontStyle.Bold);
        }

        private void BtnFS2_Click(object sender, EventArgs e)
        {
            LblWord.Font = new Font("標楷體", 36, FontStyle.Italic);
        }
    }
}
