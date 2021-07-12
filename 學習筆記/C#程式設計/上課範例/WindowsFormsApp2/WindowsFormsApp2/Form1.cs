using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCmToInit_Click(object sender, EventArgs e)
        {
            double cm;

            if(double.TryParse(TxtCm.Text,out cm))
            {
                Txtinit.Text = (cm / 2.54).ToString("F2");
            }
            else
            {
                MessageBox.Show("請輸入正確數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCm.Text = "";
            }
        }

        private void BtnInitToCm_Click(object sender, EventArgs e)
        {
            double init;

            if(double.TryParse(Txtinit.Text,out init))
            {
                TxtCm.Text = (init * 2.54).ToString("F2");
            }
            else
            {
                MessageBox.Show("請輸入正確數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txtinit.Text = "";
            }
        }

        private void BtnPingToM2_Click(object sender, EventArgs e)
        {
            double ping;

            if(double.TryParse(TxtPing.Text,out ping))
            {
                Txtm2.Text = (ping * 3.3058).ToString("F2");
            }
            else
            {
                MessageBox.Show("請輸入正確數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPing.Text = "";
            }
        }

        private void BtnM2ToPing_Click(object sender, EventArgs e)
        {
            double m2;

            if(double.TryParse(Txtm2.Text,out m2))
            {
                TxtPing.Text = (m2 / 3.3058).ToString("F2");
            }
            else
            {
                MessageBox.Show("請輸入正確數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txtm2.Text = "";
            }
        }

        private void BtnKgToBon_Click(object sender, EventArgs e)
        {
            double kg;

            if(double.TryParse(TxtKg.Text,out kg))
            {
                TxtBon.Text = (kg * 2.205).ToString("F2");
            }
            else
            {
                MessageBox.Show("請輸入正確數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtKg.Text = "";
            }
        }

        private void BtnBonToKg_Click(object sender, EventArgs e)
        {
            double bon;

            if(double.TryParse(TxtBon.Text,out bon))
            {
                TxtKg.Text = (bon / 2.205).ToString("F2");
            }
            else
            {
                MessageBox.Show("請輸入正確數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBon.Text = "";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBon.Clear();
            TxtCm.Clear();
            Txtinit.Clear();
            TxtKg.Clear();
            Txtm2.Clear();
            TxtPing.Clear();
        }
    }
}
