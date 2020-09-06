using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] name = new string[]{"張傑傑","廖美美",
                "林珊珊","周家家","蔡雯雯","吳凱凱"};//姓名字串陣列
            int[] h = new int[] { 170, 168, 165, 164, 172, 160 };//身高整數陣列
            int[] w = new int[] { 60, 55, 72, 59, 55, 54 };//體重整數陣列

            int h_total = 0, w_total = 0;//身高總和以及體重總和
            double BMI_total = 0.0;//BMI總和
            double bmi = 0.0;//個人BMI值
            string msg = "姓名\t身高\t體重\tBMI\n";
            //用迴圈逐一讀取陣列值
            for (int i = 0; i <= name.GetUpperBound(0); i++)
            {   //計算個人的BMI值
                bmi = Math.Floor((double)w[i] / Math.Pow((double)(h[i] / 100.0), 2));
                //姓名、身高、體重和BMI加入msg字串
                msg += name[i] + "\t" + h[i].ToString() + "\t" + w[i].ToString() + "\t" + bmi.ToString() + "\n";
                h_total += h[i];//個人身高加入總和
                w_total += w[i];//個人體重加入總和
                BMI_total += Math.Floor(bmi);//個人BMI值加入總和
            }
            //姓名、身高、體重和BMI的平均值加入msg字串
            msg += "\n平均\t" + (h_total / 6) + "\t" + (w_total / 6) + "\t" + Math.Floor(BMI_total / 6) + "\n";
            MessageBox.Show(msg);//顯示msg字串
            Application.Exit();
        }
    }
}
