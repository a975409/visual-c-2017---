using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try   //例外處理
            {
                int num, total = 0;
                num = Convert.ToInt32(TxtNum.Text);   //取得輸入的正整數
                if (num < 7 || num > 100)   //如果num < 7 或 > 100 時
                {
                    MessageBox.Show("請輸入大於7小於100的正整數","錯誤");
                    return; //離開btnOK_Click事件處理函式
                }

                string str = "1到" + num.ToString() + "被7整除的數：\n";
                for (int i = 1; i <= num; i++)  //for迴圈由1到num
                {
                    if (i % 7 == 0) //如果i除以7的餘數為0
                    {
                        str += i.ToString() + "\n"; //i加入字串str中
                        total += i; //i加入總和total中
                    }
                }
                str += "--------------------\n";
                str += "總和等於" + total.ToString();
                MessageBox.Show(str);
            }
            catch    //發生例外時
            {
                MessageBox.Show("請輸入數字", "錯誤");
            }
        }
    }
}
