using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "洪荒之力";
            fontDialog1.ShowColor = true;    //顯示顏色設定清單
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            //檢查是否按<確定>鈕
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //若按<確定>鈕，將字型設定顯示在LblMsg上面
                LblMsg.Font = fontDialog1.Font;
                LblMsg.ForeColor = fontDialog1.Color;   //將設定顏色當LblMsg的前景色
            }
        }

        private void BtnBColor_Click(object sender, EventArgs e)
        {
            //檢查是否未按<取消>鈕
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LblMsg.BackColor = colorDialog1.Color;    //將設定顏色當LblMsg的背景色
            }
        }
    }
}
