using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex08_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //計算和顯示圓形面積
        private void GetArea(int r)
        {
            double a = 3.14 * r * r;
            MessageBox.Show("半徑為" + r.ToString() + "的圓形面積為" + a.ToString(), "面積");
        }

        //計算和顯示長方形面積
        private void GetArea(int h, int w)
        {
            int a = h * w;
            MessageBox.Show("高為" + h.ToString() + ",寬為" + w.ToString() + "的長方形面積為" + a.ToString(), "面積");
        }

        //計算和顯示梯形面積
        private void GetArea(int x, int y, int h)
        {
            double a = (x + y) * h / 2;
            MessageBox.Show("上底為" + x.ToString() + ",下底為" + y.ToString() + ",高為" + h.ToString() + "的梯形面積為" + a.ToString(), "面積");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetArea(12);
            GetArea(12, 36);
            GetArea(6, 8, 7);
            Application.Exit();
        }
    }
}
