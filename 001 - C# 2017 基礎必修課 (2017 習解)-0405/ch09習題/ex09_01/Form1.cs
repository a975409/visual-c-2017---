using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtMove_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:  //按向右鍵
                    if (TxtMove.Left >= ClientSize.Width)  //若超過工作區的寬度
                    {
                        TxtMove.Left = -TxtMove.Width;
                    }
                    else
                    {
                        TxtMove.Left += 10;//右移10點
                    }
                    break;
                case Keys.Left:  //按向左鍵
                    if (TxtMove.Width + TxtMove.Left <= 0)  //若超過工作區的左邊界
                    {
                        TxtMove.Left = ClientSize.Width;
                    }
                    else
                    {
                        TxtMove.Left -= 10;//左移10點
                    }
                    break;
                case Keys.Down:  //按向下鍵
                    if (TxtMove.Top >= ClientSize.Height)  //若超過工作區的高度
                    {
                        TxtMove.Top =  - TxtMove.Height;
                    }
                    else
                    {
                        TxtMove.Top += 10;//下移10點
                    }
                    break;
                case Keys.Up:  //按向上鍵
                    if (TxtMove.Height + TxtMove.Top <= 0)  //若超過工作區的上邊界
                    {
                        TxtMove.Top = ClientSize.Height;
                    }
                    else
                    {
                        TxtMove.Top -= 10;//上移10點
                    }
                    break;
            }
        }
    }
}
