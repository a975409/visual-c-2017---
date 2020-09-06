using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13_2
{
    public partial class FrmSel : Form
    {
        public FrmSel()
        {
            InitializeComponent();
        }

        public string Name = "";
        public int Chi, Eng, MathScore;

        private void FrmSel_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Name + " 您的成績如下：\n\n";
            richTextBox1.Text += "國文：" + Chi.ToString() + "\n";
            richTextBox1.Text += "英文：" + Eng.ToString() + "\n";
            richTextBox1.Text += "數學：" + MathScore.ToString() + "\n\n";
            richTextBox1.Text += "總分：" + (Chi + Eng + MathScore).ToString() + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
