using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] price = new int[] { 2400, 1600, 3000, 2600, 3500 };//價格陣列
        //房型陣列
        string[] type = new string[] { "雙人房 A", "雙人房 B", "四人房 A", "四人房 B", "家庭房" };
        //房型簡介陣列
        string[] msg = new string[] { "頂級套房，蜜月專屬。", "普通套房，普通衛浴、電視。",
            "小木屋，有客廳、按摩衛浴、SPA...", "普通套房，普通衛浴、電視。",
            "兩層木屋，有客廳、按摩衛浴、SPA..." };

        TextBox[] txt = new TextBox[5];//文字方塊控制項陣列
        CheckBox[] chk = new CheckBox[5];//核取方塊控制項陣列

        private void Form1_Load(object sender, EventArgs e)
        {
            txt[0] = TxtRoom1; txt[1] = TxtRoom2; txt[2] = TxtRoom3;
            txt[3] = TxtRoom4; txt[4] = TxtRoom5;//指定文字方塊控制項陣列元素值
            chk[0] = ChkRoom1; chk[1] = ChkRoom2; chk[2] = ChkRoom3;
            chk[3] = ChkRoom4; chk[4] = ChkRoom5;//指定核取方塊控制項陣列元素值
            LblMsg.Text = "歡迎光臨 Visual 民宿";
            for (int i = 0; i <= 4; i++)
            {
                chk[i].Text = type[i] + "   " + price[i].ToString() + "元";//設定核取方塊的Text值
                //因為控制項事件內的程式碼類似，所以使用共用事件
                chk[i].CheckedChanged += My_CheckedChanged;
                chk[i].MouseEnter += My_MouseEnter;
                chk[i].MouseLeave += My_MouseLeave;
                txt[i].KeyPress += My_KeyPress;
                txt[i].TextChanged += My_TextChanged;
                txt[i].Enabled = false;//預設文字方塊不能使用
            }
            LblTotal.Text = "請勾選房型並輸入間數";
        }
        //核取方塊CheckedChanged事件的共用事件
        private void My_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)//逐一檢查核取方塊控制項陣列
            {
                if (sender.Equals(chk[i]))//若是目前的核取方塊
                {
                    txt[i].Enabled = chk[i].Checked;//設文字方塊可否使用和核取方取的勾選相同
                    txt[i].Focus();//文字方塊取得停駐焦點
                }
            }
            int total = 0;//預設總金額=0
            for (int i = 0; i <= 4; i++)//逐一檢查控制項陣列元素
            {
                if (chk[i].Checked == true && txt[i].Text != "")//若有勾選且房數不是空字串
                {
                    int rooms = Convert.ToInt32(txt[i].Text);//取得房間數
                    total += rooms * price[i];//房數*房價加入到總金額
                }
            }
            LblTotal.Text = "總金額：" + total.ToString() + "元";
        }
        //核取方塊MouseEnter事件的共用事件
        private void My_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)//逐一檢查核取方塊控制項陣列
            {
                if (sender.Equals(chk[i]))//若是目前的核取方塊
                {
                    LblMsg.Text = msg[i];//指定lblMsg.Text = msg[i]陣列元素值
                    return;//離開事件
                }
            }
        }
        //核取方塊MouseLeave事件的共用事件
        private void My_MouseLeave(object sender, EventArgs e)
        {
            LblMsg.Text = "歡迎光臨 Visual 民宿";
        }
        //文字方塊KeyPress事件的共用事件
        private void My_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')  //若不是0~9
            {
                if (e.KeyChar != '\b')  //若不是退位鍵
                {
                    e.Handled = true;  //取消輸入的字元
                }
            }
        }
        //文字方塊TextChanged事件的共用事件
        private void My_TextChanged(object sender, EventArgs e)
        {
            int total = 0;//預設總金額=0
            for (int i = 0; i <= 4; i++)//逐一檢查控制項陣列元素
            {
                if (chk[i].Checked == true && txt[i].Text != "")//若有勾選且房數不是空字串
                {
                    int rooms = Convert.ToInt32(txt[i].Text);//取得房間數
                    total += rooms * price[i];//房數*房價加入到總金額
                }
            }
            LblTotal.Text = "總金額：" + total.ToString() + "元";
        }
    }
}
