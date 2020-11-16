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

        Device selectPC;
        Device selectLCD;
        List<Device> selectother;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectother = new List<Device> { };
            selectPC = null;
            selectLCD = null;
            selectother.Clear();
            LstPC.Items.Clear();
            CboCRT.Items.Clear();
            ClbDecive.Items.Clear();

            foreach (var p in PCs)
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
            selectPC = PCs[_index];
            updateShop();
        }

        private void CboCRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _index = CboCRT.SelectedIndex;
            selectLCD = PCs[_index];
            updateShop();
        }

        private void ClbDecive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectother!=null)
                selectother.Clear();

            foreach (int a in ClbDecive.CheckedIndices)
            {
                selectother.Add(Other[a]);
            }
            updateShop();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Price_Sum();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            updateShop();
            Price_Sum();
        }

        public void updateShop()
        {
            LstShop.Items.Clear();

            if (selectPC != null)
                LstShop.Items.Add(selectPC.pc + "(" + selectPC.price + ")");

            if (selectLCD != null)
                LstShop.Items.Add(selectLCD.pc + "(" + selectLCD.price + ")");

            if (selectother != null)
            {
                foreach (var p in selectother)
                {
                    LstShop.Items.Add(p.pc + "(" + p.price + ")");
                }
            }
            
        }

        public void Price_Sum()
        {
            int result = 0;
            if (selectPC != null)
                result += selectPC.price;

            if (selectLCD != null)
                result += selectLCD.price;

            if (selectother != null)
            {
                foreach (var p in selectother)
                {
                    result += p.price;
                }
            }
                
            LblSum.Text = "合計：" + result;
        }
    }
}
