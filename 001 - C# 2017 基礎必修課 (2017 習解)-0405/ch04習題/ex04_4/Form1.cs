using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (RdbA1.Checked)  //若選取時尚機
                total += 5980;
            else if (RdbA2.Checked)  //若選取功能機
                total += 4980;
            else  //其餘即選取可愛機
                total += 2980;
            if (ChkC1.Checked)  //若選取記憶卡，加599元
                total += 599;
            if (ChkC2.Checked)  //若選取電池，加499元
                total += 499;
            if (RdbB1.Checked)  //若選取清潔組
                groupBox2.Tag = RdbB1.Text;  //將購品名稱存放於groupBox2.Tag之中
            else if (RdbB2.Checked)  //若選取保護貼
                groupBox2.Tag = RdbB2.Text;
            else  //其餘即選取防潮盒
                groupBox2.Tag = RdbB3.Text;
            LblMsg.Text = "總價" + total.ToString() + "元，加贈" + groupBox2.Tag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RdbA1.Checked = true;
            RdbB1.Checked = true;
            LblMsg.Text = "挑選後請按確定鈕";
        }
    }
}
