using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 台塑牛排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMain.Text = "台塑牛排";
        }

        private void 海陸大餐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMain.Text = "海陸大餐";
        }

        private void 海鮮特餐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMain.Text = "海鮮特餐";
        }

        private void 碳烤羊排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMain.Text = "碳烤羊排";
        }

        private void 德國豬排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMain.Text = "德國豬腳";
        }

        private void 義大利麵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSecond.Text = "義大利麵";
        }

        private void 總匯沙拉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSecond.Text = "總匯沙拉";
        }

        private void 奶油焗蟹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSecond.Text = "奶油焗蟹";
        }

        private void 海鮮濃湯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSecond.Text = "海鮮濃湯";
        }

        private void 紅酒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDrink.Text = "紅酒";
        }

        private void 水果茶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDrink.Text = "水果茶";
        }

        private void 咖啡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDrink.Text = "咖啡";
        }

        private void 果汁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDrink.Text = "果汁";
        }

        private void 礦泉水ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDrink.Text = "礦泉水";
        }

        private void 蛋糕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDessert.Text = "蛋糕";
        }

        private void 布丁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDessert.Text = "布丁";
        }

        private void 果凍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDessert.Text = "果凍";
        }

        private void 水果乳酪ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDessert.Text = "水果乳酪";
        }
    }
}
