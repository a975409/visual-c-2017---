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
    public partial class FrmInput : Form
    {
        public FrmInput()
        {
            InitializeComponent();
        }

        public string Name = "";
        public int Chi, Eng, MathScore;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Name = textBox1.Text;
                Chi = Convert.ToInt32(textBox2.Text);
                Eng = Convert.ToInt32(textBox3.Text);
                MathScore = Convert.ToInt32(textBox4.Text);
                this.Hide();
            }
            catch
            {
                MessageBox.Show("資料輸入有誤");
            }
        }
    }
}
