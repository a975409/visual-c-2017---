using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] s_name = new string[] { "黑松汽水", "舒跑" }; //品名字串陣列預設兩筆資料
        int[] s_money = new int[] { 12, 14 }; //成本整數陣列預設兩筆資料
        int[] s_price = new int[] { 18, 20 }; //售價整數陣列預設兩筆資料

        private void Form1_Load(object sender, EventArgs e)
        {
            CboName.Items.AddRange(s_name);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {   //若cboName、txtMoney、txtPrice都有輸入
            if (CboName.Text != "" && TxtMoney.Text != "" && TxtPrice.Text != "")
            {
                int i = CboName.FindStringExact(CboName.Text);//搜尋輸入的品名
                if (i == -1)    //若搜尋不到
                {
                    try
                    {
                        int money = Convert.ToInt32(TxtMoney.Text);//讀取成本
                        int price = Convert.ToInt32(TxtPrice.Text);//讀取售價
                        CboName.Items.Add(CboName.Text);//新增輸入品名的項目
                        Array.Resize(ref s_money, s_money.Length + 1);//s_money陣列加大1的元素
                        Array.Resize(ref s_price, s_price.Length + 1);//s_price陣列加大1的元素
                        s_money[s_money.Length - 1] = money;//設定s_money陣列最後一個元素的值
                        s_price[s_price.Length - 1] = price;//設定s_price陣列最後一個元素的值
                        MessageBox.Show("新增資料成功", "注意");
                    }
                    catch
                    {
                        MessageBox.Show("成本和售價請輸入數值", "注意");
                    }
                }
                else   //若搜尋到
                {
                    try   //例外處理
                    {
                        int money = Convert.ToInt32(TxtMoney.Text);//讀取成本
                        int price = Convert.ToInt32(TxtPrice.Text);//讀取售價
                        s_money[i] = money;//更改s_money陣列的對應值
                        s_price[i] = price;//更改s_price陣列的對應值
                        MessageBox.Show("成本和售價修改成功", "注意");
                    }
                    catch   //發生例外時
                    {
                        MessageBox.Show("成本和售價請輸入數值", "注意");
                    }
                }
            }
            else   //若輸入資料不完整
            {
                MessageBox.Show("請完整輸入品名、成本和售價", "注意");
            }
        }

        private void CboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboName.SelectedIndex >= 0)//若有選取項目
            {
                TxtMoney.Text = s_money[CboName.SelectedIndex].ToString();//成本顯示對應的陣列值
                TxtPrice.Text = s_price[CboName.SelectedIndex].ToString();//售價顯示對應的陣列值
            }
        }
    }
}
