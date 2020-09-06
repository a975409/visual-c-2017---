using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex08_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtItem1.Text = "0";    //預設治安分數為0
            TxtItem2.Text = "0";    //預設交通分數為0
            TxtItem3.Text = "0";    //預設效率分數為0
            TxtItem1.Focus();       //治安文字方塊取得焦點
            TxtItem1.TextChanged += My_TextChanged; //治安文字方塊的TextChanged事件共用My_TextChanged事件
            TxtItem2.TextChanged += My_TextChanged; //交通文字方塊的TextChanged事件共用My_TextChanged事件
            TxtItem3.TextChanged += My_TextChanged; //效率文字方塊的TextChanged事件共用My_TextChanged事件
            LblMsg.Text = string.Empty;    //預設LblMsg的文字為空白
        }

        private void My_TextChanged(object sender, EventArgs e)
        {
            string msg = "";    //預設輸入項目為空白
            if (sender.Equals(TxtItem1))    //若是治安文字方塊
            {
                msg = "治安";
            }
            else if (sender.Equals(TxtItem2))//若是交通文字方塊
            {
                msg = "交通";
            }
            else
            {
                msg = "效率";
            }
            LblMsg.Text = "現在輸入的項目是：" + msg;    //顯示輸入的項目
            try    //因為輸入的資料可能產生錯誤
            {

                int score1 = Convert.ToInt32(TxtItem1.Text);    //取得治安分數
                int score2 = Convert.ToInt32(TxtItem2.Text);    //取得交通分數
                int score3 = Convert.ToInt32(TxtItem3.Text);    //取得效率分數
                if ((score1 >= 0 && score1 <= 40) && (score2 >= 0 && score2 <= 30)
                    && (score3 >= 0 && score3 <= 30))
                {
                    LblScore.Text = "總得分：" + (score2 + score1 + score3).ToString();
                }
                else
                {
                    LblScore.Text = "輸入分數超出範圍";
                }
            }
            catch
            {
                LblScore.Text = "請輸入數值";
            }
        }
    }
}
