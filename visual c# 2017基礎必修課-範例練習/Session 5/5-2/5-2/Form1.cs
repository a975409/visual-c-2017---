using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg1 = "";
            for(int i=1;i<=6;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    msg1 += "* ";
                }
                msg1 += "\n";
            }
            MessageBox.Show(msg1);

            string msg2 = "";
            for (int i = 6; i >= 1; i--)
            {
                int temp = 0;
                for (int j = 1; j < i; j++)
                {
                    msg2 += "   ";
                    temp = j;
                }

                for(int k=1;k<=6-temp;k++)
                {
                    msg2 += "* ";
                }
                msg2 += "\n";
            }
            MessageBox.Show(msg2);

            string msg3 = "";
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= i && i<=4; j++)
                {
                    msg3 += "* ";
                }

                for (int j = 1; j <= 7-i+1 && i > 4; j++)
                {
                    msg3 += "* ";
                }
                msg3 += "\n";
            }
            MessageBox.Show(msg3);

            Application.Exit();
        }
    }
}
