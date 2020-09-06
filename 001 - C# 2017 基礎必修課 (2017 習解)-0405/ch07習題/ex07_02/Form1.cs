using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblColor.BackColor = Color.FromArgb(0, 0, 0);
            LblColor.ForeColor = Color.FromArgb(255, 255, 255);
            LblColor.Text = "紅=0 綠=0 藍=0";
        }

        private void TkbRed_Scroll(object sender, EventArgs e)
        {
            LblColor.BackColor = Color.FromArgb(TkbRed.Value, TkbGreen.Value, TkbBlue.Value);
            LblColor.ForeColor = Color.FromArgb(255-TkbRed.Value, 255-TkbGreen.Value, 255-TkbBlue.Value);
            LblColor.Text = "紅=" + TkbBlue.Value + " 綠=" + TkbGreen.Value + " 藍=" + TkbRed.Value;
        }
        //以下程式碼內容和TkbRed_Scroll相同，下章會介紹共用事件的方法
        private void TkbGreen_Scroll(object sender, EventArgs e)
        {
            LblColor.BackColor = Color.FromArgb(TkbRed.Value, TkbGreen.Value, TkbBlue.Value);
            LblColor.ForeColor = Color.FromArgb(255 - TkbRed.Value, 255 - TkbGreen.Value, 255 - TkbBlue.Value);
            LblColor.Text = "紅=" + TkbBlue.Value + " 綠=" + TkbGreen.Value + " 藍=" + TkbRed.Value;
        }

        private void TkbBlue_Scroll(object sender, EventArgs e)
        {
            LblColor.BackColor = Color.FromArgb(TkbRed.Value, TkbGreen.Value, TkbBlue.Value);
            LblColor.ForeColor = Color.FromArgb(255 - TkbRed.Value, 255 - TkbGreen.Value, 255 - TkbBlue.Value);
            LblColor.Text = "紅=" + TkbBlue.Value + " 綠=" + TkbGreen.Value + " 藍=" + TkbRed.Value;
        }
    }
}
