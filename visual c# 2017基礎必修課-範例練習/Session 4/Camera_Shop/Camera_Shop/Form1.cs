using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int dollor = 0;
            string msg = "";

            if(RdbCamera_5980.Checked)
            {
                dollor += 5980;
            }
            else if(RdbCamera_4980.Checked)
            {
                dollor += 4980;
            }
            else
            {
                dollor += 2980;
            }

            if(ChkSD.Checked)
            {
                dollor += 599;
            }

            if(ChkBattery.Checked)
            {
                dollor += 499;
            }
            msg = "總價" + dollor + "元";

            if (RdbClean.Checked)
            {
                msg += "，加贈清潔組";
            }
            else if (RdbMoistureproof.Checked)
            {
                msg += "，加贈防潮盒";
            }
            else
            {
                msg += "，加贈保護貼";
            }
            LblMsg.Text = msg;
        }
    }
}
