using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightSpeedRoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtKm.TabIndex = 0;
            radioButton1.Checked = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int km = Convert.ToInt32(TxtKm.Text);
            }
            catch
            {

            }
        }
    }
}
