using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05_02b
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
            for (int y = 1; y <= 6; y++)
            {
                for (int x = 1; x <= 6; x++)
                {
                    if (x > 6 - y)
                    {
                        str += "＊";
                    }
                    else
                    {
                        str += "　";
                    }
                }
                str += "\n";
            }
            MessageBox.Show(str, "( b )");
            Application.Exit();
        }
    }
}
