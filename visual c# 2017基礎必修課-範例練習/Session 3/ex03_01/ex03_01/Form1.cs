using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03_01
{
    public partial class Form1 : Form
    {
        FontFamily family;
        float emSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBlack_Click(object sender, EventArgs e)
        {
            LblMsg.BackColor = Color.Black;
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            LblMsg.BackColor = Color.Yellow;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Red;
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Blue;
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(family, emSize, FontStyle.Bold);
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(family, emSize, FontStyle.Italic);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            family = LblMsg.Font.FontFamily;
            emSize = LblMsg.Font.Size;
        }
    }
}
