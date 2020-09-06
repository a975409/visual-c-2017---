using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] title1 = new string[]{ "營業處", "第1季", "第2季", "第3季", "第4季", "合計" };
            string[] locations = new string[] { "台北", "台中", "高雄" };

            int[,] Turnovers = new int[,] { { 1000, 2000, 3000, 4000 },
                                            { 1500, 2500, 3500, 4500 },
                                            { 3200, 1800, 3600, 1400 } };

            string msg = "";

            foreach(string a in title1)
            {
                msg += a + "\t";
            }
            msg += "\n\n";

            for(int i=0;i<3;i++)
            {
                int sum = 0;
                msg += locations[i] + "\t";

                for(int j=0;j<4;j++)
                {
                    sum += Turnovers[i, j];
                    msg += Turnovers[i, j] + "\t";
                }
                msg += sum + "\n";
            }

            MessageBox.Show(msg, "營業報表");

            msg = "";
            string[] title2 = new string[] { "營業處", "台北", "台中", "高雄", "合計" };
            string[] periods = new string[] { "第1季", "第2季", "第3季", "第4季" };

            foreach (string a in title2)
            {
                msg += a + "\t";
            }
            msg += "\n\n";

            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                msg += periods[i] + "\t";

                for (int j = 0; j < 3; j++)
                {
                    sum += Turnovers[j, i];
                    msg += Turnovers[j, i] + "\t";
                }
                msg += sum + "\n";
            }
            MessageBox.Show(msg, "營業報表");
            Application.Exit();
        }
    }
}
