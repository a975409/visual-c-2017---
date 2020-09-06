using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex06_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClbStyle.CheckOnClick = true;//設按一下就改變勾選狀況
            ClbStyle.Items.Add("粗體字");   //新增清單項目
            ClbStyle.Items.Add("斜體字");
            ClbStyle.Items.Add("加底線");
            ClbStyle.Items.Add("刪除線");
        }

        private void ClbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClbStyle.SelectedIndex == 0)//若選第一個項目
            {   //原字型樣式和FontStyle.Bold做Xor運算(即原為粗體改為非粗體，原非粗體改為粗體，其他樣式不變)
                LblWord.Font = new Font(LblWord.Font, LblWord.Font.Style ^ FontStyle.Bold);
            }
            else if (ClbStyle.SelectedIndex == 1)//若選第二個項目
            {   //原字型樣式和FontStyle.Italic做Xor運算
                LblWord.Font = new Font(LblWord.Font, LblWord.Font.Style ^ FontStyle.Italic);
            }
            else if (ClbStyle.SelectedIndex == 2)//若選第三個項目
            {   //原字型樣式和FontStyle.Underline做Xor運算
                LblWord.Font = new Font(LblWord.Font, LblWord.Font.Style ^ FontStyle.Underline);
            }
            else if (ClbStyle.SelectedIndex == 3)//若選第四個項目
            {   //原字型樣式和FontStyle.Strikeout做Xor運算
                LblWord.Font = new Font(LblWord.Font, LblWord.Font.Style ^ FontStyle.Strikeout);
            }
        }
    }
}
