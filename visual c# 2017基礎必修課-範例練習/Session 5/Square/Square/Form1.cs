using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string i;
            double num = 0;
            bool pass = true;
            DialogResult msgresult = DialogResult.None;

            do
            {
                i = Microsoft.VisualBasic.Interaction.InputBox("請輸入數值：", "求平方");
                try
                {
                    num = Convert.ToDouble(i);
                    pass = true;
                    msgresult = MessageBox.Show(i + "的平方等於" + (num * num).ToString("f2") + "\n是否繼續?", "平方", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                catch
                {
                    MessageBox.Show("請輸入數值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass = false;
                }

            } while (pass == false || msgresult == DialogResult.Yes);
            
            Application.Exit();
        }
    }
}
