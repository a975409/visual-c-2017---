using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicTra.SizeMode = PictureBoxSizeMode.StretchImage;
            PicTra.Image = Image.FromFile("TRFFC10A.ICO");
        }

        private void PicTra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)  //若按右鍵
            {
                PicTra.Image = Image.FromFile("TRFFC10B.ICO");
            }
            else  //其餘
            {
                PicTra.Image = Image.FromFile("TRFFC10C.ICO");
            }
        }

        private void PicTra_MouseUp(object sender, MouseEventArgs e)
        {
            PicTra.Image = Image.FromFile("TRFFC10A.ICO");
        }
    }
}
