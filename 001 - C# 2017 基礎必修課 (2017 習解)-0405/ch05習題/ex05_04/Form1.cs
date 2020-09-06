using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int cash, total;    //宣告收現金額、消費金額
            try     //例外處理
            {
                cash = Convert.ToInt32(TxtCash.Text);   //取得收現金額
                total = Convert.ToInt32(TxtTotal.Text); //取得消費金額
            }
            catch   //取得收現或消費金額產生錯誤時
            {
                MessageBox.Show("請輸入數字");
                return; //離開事件程序
            }
            //宣告1000元、500元、100元、50元、10元、1元找錢數量和找零金額
            int n1000, n500, n100, n50, n10, n5, n1, change;
            if (cash >= total)  //當收現金額大於等於消費金額時
            {
                change = cash - total;  //找零金額
                LblChange.Text = change.ToString(); //顯示找零金額
                n1000 = change / 1000;  //1000元的找錢數量
                change %= 1000;         //找1000元後剩餘的找零金額
                n500 = change / 500;    //500元的找錢數量
                change %= 500;          //找500元後剩餘的找零金額
                n100 = change / 100;    //100元的找錢數量
                change %= 100;          //找100元後剩餘的找零金額
                n50 = change / 50;      //50元的找錢數量
                change %= 50;           //找50元後剩餘的找零金額
                n10 = change / 10;      //10元的找錢數量
                change %= 10;           //找10元後剩餘的找零金額
                n5 = change / 5;        //5元的找錢數量
                change %= 5;            //找5元後剩餘的找零金額
                n1 = change;            //剩餘金額就是1元的找錢數量
                Lbl1000.Text = n1000.ToString();    //顯示1000元的找錢數量
                Lbl500.Text = n500.ToString();
                Lbl100.Text = n100.ToString();
                Lbl50.Text = n50.ToString();
                Lbl10.Text = n10.ToString();
                Lbl5.Text = n5.ToString();
                Lbl1.Text = n1.ToString();
            }
            else  //當收現金額小於消費金額時
            {
                MessageBox.Show("收現金額不足！請注意！！");
            }
        }
    }
}
