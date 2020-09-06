using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Pal,rate;

        private void Form1_Load(object sender, EventArgs e)
        {
            Pal = 10000;
            rate = 0.03;

            TxtPal.Text = Pal.ToString();
            TxtRate.Text = (rate * 100).ToString();
            TxtInt.ReadOnly = true;
            Calculation();
            //TxtInt.Text = Calculation().ToString();
        }

        private void TxtPal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Pal = Convert.ToDouble(TxtPal.Text);
            }
            catch
            {
                //MessageBox.Show("本金輸入錯誤");
                Pal = 0;
                TxtPal.Clear();
                TxtPal.Focus();
            }
            Calculation();
        }

        private void TxtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rate = Convert.ToDouble(TxtRate.Text) * 0.01;
            }
            catch
            {
                //MessageBox.Show("年利率輸入錯誤");
                rate = 0;
                TxtRate.Clear();
                TxtRate.Focus();
            }
            Calculation();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Calculation()
        {
            TxtInt.Text = (Pal * rate).ToString();
        }
    }
}
