using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TxtMoney的Text屬性值 = "10000"在設計階段設定以避免造成例外錯誤
            TxtRate.Text = "3";  //預設年利率為3
        }

        private void TxtMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {   //利息公式：利息 = 本金x年利率
                LblReturn.Text = Convert.ToString(Convert.ToDouble(TxtMoney.Text) * Convert.ToDouble(TxtRate.Text) * 0.01);
            }
            catch
            {
                MessageBox.Show("本金請輸入數值！", "注意");
            }
        }

        private void TxtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {   //利息公式：利息 = 本金x年利率
                LblReturn.Text = Convert.ToString(Convert.ToDouble(TxtMoney.Text) * Convert.ToDouble(TxtRate.Text) * 0.01);
            }
            catch
            {
                MessageBox.Show("年利率請輸入數值！", "注意");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
