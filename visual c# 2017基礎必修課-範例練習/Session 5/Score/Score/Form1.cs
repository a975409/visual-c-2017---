using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = "座號" + "\t" + "計概" + "\t" + "程式設計" + "\n";
            string score = string.Empty;
            for(int no=1;no<=3;no++)
            {
                msg += no + "號" + "\t";
                for(int sub=1;sub<=2;sub++)
                {
                    score = Microsoft.VisualBasic.Interaction.InputBox(sub == 1 ? "計概" : "程式設計", no + "號成績");
                    msg += score + "\t";
                }
                msg += "\n";
            }

            MessageBox.Show(msg, "成績表");
            Application.Exit();
        }
    }
}
