using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex07_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int mon = McaMonth.SelectionRange.Start.Month;//取得選取開始日期的月份
            switch (mon)//用switch選擇結構根據月份來開啟對應讀檔
            {
                case 3:
                case 4:
                case 5:
                    PicMonth.Image = Image.FromFile("春.jpg");
                    break;
                case 6:
                case 7:
                case 8:
                    PicMonth.Image = Image.FromFile("夏.jpg");
                    break;
                case 9:
                case 10:
                case 11:
                    PicMonth.Image = Image.FromFile("秋.jpg");
                    break;
                default:
                    PicMonth.Image = Image.FromFile("冬.jpg");
                    break;
            }
        }

        private void McaMonth_DateChanged(object sender, DateRangeEventArgs e)
        {
            Form1_Load(sender, e);  //因為程式碼內容相同，所以直接呼叫Form1_Load
        }
    }
}
