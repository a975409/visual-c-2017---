using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtQtyF.Text = "0";
            TxtQtyF.Focus();
        }

        private void TxtQtyF_Enter(object sender, EventArgs e)
        {
            TxtQtyF.Clear();
        }

        private void TxtQtyF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sumF;

                sumF = Convert.ToInt32(LblPriceF.Text) * Convert.ToInt32(TxtQtyF.Text);
                LblSumF.Text = sumF.ToString();
            }
            catch
            {
                LblSumF.Text = "0";
            }
        }
    }
}
