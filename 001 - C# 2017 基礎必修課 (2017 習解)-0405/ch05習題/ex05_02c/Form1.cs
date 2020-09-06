using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05_02c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = string.Empty;
            for (int y = 1; y <= 7; y++)
            {
                for (int x = 1; x <= 4; x++)
                {
                    str += "＊";
                    if (y <= 3)
                    {
                        if (x == y) break;
                    }
                    else
                    {
                        if (x == 8 - y) break;
                    }
                }
                str += "\n";
            }
            MessageBox.Show(str, "( c )");
            Application.Exit();
        }
    }
}
