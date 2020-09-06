using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_homework
{
    public partial class Form1 : Form
    {
        int Sum250;
        int Sum200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sum250 = 0;
            Sum200 = 0;
            LblPrice_200.Text = "200";
            LblPrice_250.Text = "250";

            TxtQty200.Text = "0";
            TxtQty250.Text = "0";

            TxtQty250.TabIndex = 0;
        }

        private void TxtQty250_Enter(object sender, EventArgs e)
        {
            TxtQty250.Clear();
        }

        private void TxtQty250_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Sum250 = Convert.ToInt32(LblPrice_250.Text) * Convert.ToInt32(TxtQty250.Text);
             }
            catch
            {
                Sum250 = 0;
            }
            LblSum250.Text = Sum250.ToString();
        }

        private void TxtQty200_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Sum200 = Convert.ToInt32(LblPrice_200.Text) * Convert.ToInt32(TxtQty200.Text);
            }
            catch
            {
                Sum200 = 0;
            }
            LblSum200.Text = Sum200.ToString();
        }

        private void TxtQty200_Enter(object sender, EventArgs e)
        {
            TxtQty200.Clear();
        }

        private void LblSum250_TextChanged(object sender, EventArgs e)
        {
            LblAllSum.Text = (Sum200 + Sum250).ToString();
        }
    }
}
