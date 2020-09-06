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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public string Name = "";
        public int Chi, Eng, MathScore;

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInput f = new FrmInput();
            f.ShowDialog();
            Name = f.Name;
            Chi = f.Chi;
            Eng = f.Eng;
            MathScore = f.MathScore;
            f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSel f = new FrmSel();
            f.Name = Name;
            f.Chi = Chi;
            f.Eng = Eng;
            f.MathScore = MathScore;
            f.ShowDialog();
            f.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
