using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicDiy
{
    public partial class Form1 : Form
    {
        Device[] PCs = new Device[] { new Device("華碩主機",20000),
                                new Device("基峰主機",18000),
                                new Device("技嘉主機",15000),
                                new Device("菁英主機",12000)};

        Device[] LCDs = new Device[] { new Device("15吋",4000),
                                new Device("17吋",5000),
                                new Device("19吋",6000)};

        Device[] Other = new Device[] { new Device("滑鼠",300),
                                new Device("鍵盤",400),
                                new Device("8G隨身碟",500),
                                new Device("DVD燒錄器",800)};

        int PC_Sum, Device_Sum, Other_Sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var p in PCs)
            {
                LstPC.Items.Add(p.pc + "(" + p.price + ")");
            }

            foreach (var p in LCDs)
            {
                CboCRT.Items.Add(p.pc + "(" + p.price + ")");
            }

            foreach (var p in Other)
            {
                ClbDecive.Items.Add(p.pc + "(" + p.price + ")");
            }
        }

        private void LstPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _index = LstPC.SelectedIndex;
            //if (_index >= 0)
            //{
            //    PC_Sum = PCs[_index].price;
            //    Price_Sum();
            //}
            PC_Sum = PCs[_index].price;
            Price_Sum();
        }

        private void CboCRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _index = CboCRT.SelectedIndex;
            //if (_index >= 0)
            //{
            //    Device_Sum = LCDs[_index].price;
            //    Price_Sum();
            //}
            Device_Sum = LCDs[_index].price;
            Price_Sum();

        }

        private void ClbDecive_SelectedIndexChanged(object sender, EventArgs e)
        {
            Other_Sum = 0;
            foreach (int a in ClbDecive.CheckedIndices)
            {
                Other_Sum += Other[a].price;
            }
            Price_Sum();
        }

        public void Price_Sum()
        {
            LblSum.Text = "合計：" + (PC_Sum + Device_Sum + Other_Sum).ToString();
        }
    }
}
