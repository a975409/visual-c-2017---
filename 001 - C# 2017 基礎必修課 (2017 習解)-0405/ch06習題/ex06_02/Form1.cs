using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] menber = new string[] { "青菜", "山羊", "野狼", "農夫" };
        private void Form1_Load(object sender, EventArgs e)
        {
            LstLeft.Items.AddRange(menber);
            LstLeft.Enabled = true;     //設定左岸能選
            LstRight.Enabled = false;   //設定右岸不能選
            BtnLeft.Enabled = false;    //設定<---不能使用
        }
        //按 說明 鈕
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.農夫1次只能帶1樣或空手過河。\n2.農夫不在時山羊會吃青菜，野狼會吃山羊。\n3.3件都帶過河就過關。", "遊戲說明");
        }
        //按 ---> 鈕
        private void BtnRight_Click(object sender, EventArgs e)
        {
            string s_item;//紀錄左岸選取的項目
            LstLeft.Enabled = false;    //設定左岸不能選
            LstRight.Enabled = true;    //設定右岸能選
            BtnRight.Enabled = false;   //設定--->不能使用
            BtnLeft.Enabled = true;     //設定<---可以使用
            if (LstLeft.Text != "")
            {
                s_item = LstLeft.Text;          //取得左岸選取的項目
                LstLeft.Items.Remove(s_item);   //將選擇的項目由左岸移除
                LstRight.Items.Add(s_item);     //將選擇的項目加到右岸
                if (s_item != "農夫")  //如果選的項目不是農夫，則農夫也要過河
                {
                    LstLeft.Items.Remove("農夫"); //左岸移除農夫
                    LstRight.Items.Add("農夫");   //右岸增加農夫
                }
                //檢查左岸山羊和青菜是否同時存在
                if (LstLeft.FindStringExact("山羊") != -1 && LstLeft.FindStringExact("青菜") != -1)
                {
                    MessageBox.Show("山羊吃掉青菜");
                    //遊戲結束重新開始
                    LstLeft.Items.Clear();
                    LstLeft.Items.AddRange(menber);
                    LstRight.Items.Clear();
                    LstLeft.Enabled = true;
                    LstRight.Enabled = false;
                    BtnRight.Enabled = true; //設定--->可以使用
                    BtnLeft.Enabled = false; //設定<---不能使用
                }
                else
                {
                    //檢查左岸山羊和野狼是否同時存在
                    if (LstLeft.FindStringExact("山羊") != -1 && LstLeft.FindStringExact("野狼") != -1)
                    {
                        MessageBox.Show("野狼吃掉山羊");
                        LstLeft.Items.Clear();
                        LstLeft.Items.AddRange(menber);
                        LstRight.Items.Clear();
                        LstLeft.Enabled = true;
                        LstRight.Enabled = false;
                        BtnRight.Enabled = true; //設定--->可以使用
                        BtnLeft.Enabled = false; //設定<---不能使用
                    }
                }
            }
            if (LstRight.Items.Count == 4)//如果右岸有四個項目
            {
                MessageBox.Show("任務完成！！！");
                LstLeft.Items.Clear();
                LstLeft.Items.AddRange(menber);
                LstRight.Items.Clear();
                LstLeft.Enabled = true;
                LstRight.Enabled = false;
                BtnRight.Enabled = true; //設定--->可以使用
                BtnLeft.Enabled = false; //設定<---不能使用
                return;
            }
        }
        //按 <--- 鈕
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            string s_item = "";
            LstLeft.Enabled = true;
            LstRight.Enabled = false;
            BtnRight.Enabled = true; //設定--->可以使用
            BtnLeft.Enabled = false; //設定<---不能使用
            if (LstRight.Text != "")
            {
                s_item = LstRight.Text;
                LstRight.Items.Remove(s_item);
                LstLeft.Items.Add(s_item);
                if (s_item != "農夫")
                {
                    LstRight.Items.Remove("農夫");
                    LstLeft.Items.Add("農夫");
                }
                //檢查右岸山羊和青菜是否同時存在
                if (LstRight.FindStringExact("山羊") != -1 && LstRight.FindStringExact("青菜") != -1)
                {
                    MessageBox.Show("山羊吃掉青菜");
                    LstLeft.Items.Clear();
                    LstLeft.Items.AddRange(menber);
                    LstRight.Items.Clear();
                    LstLeft.Enabled = true;
                    LstRight.Enabled = false;
                    BtnRight.Enabled = true; //設定--->可以使用
                    BtnLeft.Enabled = false; //設定<---不能使用
                }
                else
                {
                    //檢查右岸山羊和野狼是否同時存在
                    if (LstRight.FindStringExact("山羊") != -1 && LstRight.FindStringExact("野狼") != -1)
                    {
                        MessageBox.Show("野狼吃掉山羊");
                        LstLeft.Items.Clear();
                        LstLeft.Items.AddRange(menber);
                        LstRight.Items.Clear();
                        LstLeft.Enabled = true;
                        LstRight.Enabled = false;
                        BtnRight.Enabled = true; //設定--->可以使用
                        BtnLeft.Enabled = false; //設定<---不能使用
                    }
                }
            }
        }
    }
}
