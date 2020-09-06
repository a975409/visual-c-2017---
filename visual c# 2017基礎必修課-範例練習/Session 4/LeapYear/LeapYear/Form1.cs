using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(TxtYear.Text);
                string msg = "";

                if(year%4==0 && year%100!=0)
                {
                    msg = year + "是閏年";
                }
                else if (year % 400 == 0 && year % 100 == 0)
                {
                    msg = year + "是閏年";
                }
                else
                {
                    //(year % 400 != 0 && year % 100 == 0) || (year%4!=0)
                    msg = year + "是平年";
                }

                LblAns.Text = msg;
            }
            catch
            {
                MessageBox.Show("請輸入年分", "注意");
                TxtYear.Clear();
                TxtYear.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblAns.Text = "請輸入西元年";
        }
    }
}
