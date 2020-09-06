using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPAAvg
{
    public partial class Form1 : Form
    {
        double sum_GPA;
        double sum_courese;
        string msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg = "代碼      成績      學分數     Grade     GPA積點\n";
            LblMsg.Text = msg;
        }

        private void TxtOK_Click(object sender, EventArgs e)
        {
            try
            {
                string code = TxtCode.Text;
                int score = Convert.ToInt32(TxtScore.Text);
                int hour = Convert.ToInt32(TxtHour.Text);

                string Grade = "";
                int GPA = 0;

                switch (score/10)
                {
                    case 10:
                    case 9:
                    case 8:
                        Grade = "A";
                        GPA = 4;
                        break;
                    case 7:
                        Grade = "B";
                        GPA = 3;
                        break;
                    case 6:
                        Grade = "C";
                        GPA = 2;
                        break;
                    case 5:
                        Grade = "D";
                        GPA = 1;
                        break;
                    default:
                        Grade = "E";
                        GPA = 0;
                        break;
                }

                sum_GPA += GPA * hour;
                sum_courese += hour;
                double avgGPA = sum_GPA / sum_courese;

                LblSumGPA.Text = sum_GPA.ToString();
                LblSumCourses.Text = sum_courese.ToString();
                LblAvgGPA.Text = avgGPA.ToString("F2");

                msg += code + "      " + score + "      " + hour + "      " + Grade + "      " + GPA + "\n";
                LblMsg.Text = msg;
            }
            catch
            {

            }
        }
    }
}
