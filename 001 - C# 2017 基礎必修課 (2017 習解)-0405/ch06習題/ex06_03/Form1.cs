using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //品名陣列
        string[] s_name = new string[] { "舒跑", "黑松汽水", "多喝水", "多果汁", "青箭口香糖", "王子麵", "聯合報" };
        int[] s_price = new int[] { 25, 24, 18, 20, 10, 8, 10 };//單價陣列
        int sum = 0;    //總計

        private void Form1_Load(object sender, EventArgs e)
        {
            LstName.Items.AddRange(s_name);
        }
        //點選購買物品的清單項目時
        private void LstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstName.SelectedIndex >= 0) //若選項的註標值>= 0
            {
                TxtName.Text = LstName.Text;    //顯示品名
                TxtPrice.Text = s_price[LstName.SelectedIndex].ToString();//顯示單價
                TxtNum.Text = "1";  //預設數量為1
                TxtTotal.Text = ""; //預設小計為空字串
                TxtNum.Focus();     //txtNum設為停駐焦點
            }
        }
        //按確定鈕時
        private void BtnOk_Click(object sender, EventArgs e)
        {
            try   //例外處理
            {
                if (Convert.ToInt32(TxtNum.Text) > 0)  //若輸入數量> 0
                {
                    //顯示小計(單價*數量)
                    TxtTotal.Text = (Convert.ToInt32(TxtPrice.Text) * Convert.ToInt32(TxtNum.Text)).ToString();
                    sum += Convert.ToInt32(TxtTotal.Text);  //小計加入總計中
                    TxtSum.Text = sum.ToString();   //顯示總計
                }
                else   //若沒有輸入數量
                {
                    MessageBox.Show("請輸入數量");
                }
            }
            catch   //發生例外時
            {
                MessageBox.Show("請輸入數字");
            }
        }
        //按清除鈕時
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";  //品名清空
            TxtPrice.Text = ""; //單價清空
            TxtNum.Text = "";   //清空
            TxtTotal.Text = ""; //小計清空
            TxtSum.Text = "";   //總計清空
            sum = 0;    //設總計 = 0
        }
    }
}
