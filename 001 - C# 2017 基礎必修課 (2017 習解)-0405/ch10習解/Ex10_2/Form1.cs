using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 1;

        //ShowPic程序用來顯示目前的圖示
        private void ShowPic()
        {
            pic.Image = Image.FromFile("img" + i + ".jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPic();
        }

        private void 第一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 1;
            ShowPic();
        }
     
        private void 下一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                i += 1;
            }
            else
            {
                i = 1;
            }
            ShowPic();
        }

        private void 上一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i -= 1;
            }
            else
            {
                i = 4;
            }

            ShowPic();
        }

        private void 最後一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 4;
            ShowPic();
        }
    }
}
