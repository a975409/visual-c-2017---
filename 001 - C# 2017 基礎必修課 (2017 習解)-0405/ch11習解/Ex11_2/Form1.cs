using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Rtxt.SelectionFont = fontDialog1.Font;
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Rtxt.SelectionColor = colorDialog1.Color;
            }
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            Rtxt.SelectionBullet = true;
        }

        private void BtnCancelItem_Click(object sender, EventArgs e)
        {
            Rtxt.SelectionBullet = false;
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            String filename;
            openFileDialog1.Filter = "文書檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = ".txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                Rtxt.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
