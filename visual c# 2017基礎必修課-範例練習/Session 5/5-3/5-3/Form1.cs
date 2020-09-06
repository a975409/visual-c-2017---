using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnUp_Click(object sender, EventArgs e)
        {
            int _up = PicUFO.Top - 10;

            if(_up>0)
            {
                PicUFO.Top = _up;
            }
            else
            {
                PicUFO.Top = 0;
            }
        }

        private void BtnLarge_Click(object sender, EventArgs e)
        {
            int _width = PicUFO.Width + 10;
            int _height = PicUFO.Height + 10;

            if (_width < 200)
            {
                PicUFO.Width = _width;
                PicUFO.Height = _height;
            }
            else
            {
                PicUFO.Width = 200;
                PicUFO.Height = 200;
            }
        }

        private void BtnSmall_Click(object sender, EventArgs e)
        {
            int _width = PicUFO.Width - 10;
            int _height = PicUFO.Height - 10;

            if (_width > 10)
            {
                PicUFO.Width = _width;
                PicUFO.Height = _height;
            }
            else
            {
                PicUFO.Width = 10;
                PicUFO.Height = 10;
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            int _down = PicUFO.Top + 10;

            if (_down + PicUFO.Height < ClientSize.Height)
            {
                PicUFO.Top = _down;
            }
            else
            {
                PicUFO.Top = ClientSize.Height - PicUFO.Height;
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            int _right = PicUFO.Left + 10;

            if (_right + PicUFO.Width < ClientSize.Width)
            {
                PicUFO.Left = _right;
            }
            else
            {
                PicUFO.Left = ClientSize.Width - PicUFO.Width;
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            int _left = PicUFO.Left - 10;

            if (_left > 0)
            {
                PicUFO.Left = _left;
            }
            else
            {
                PicUFO.Left = 0;
            }
        }

    }
}
