using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string uName = Microsoft.VisualBasic.Interaction.InputBox("請輸入姓名", "輸入");

            if(uName=="")
            {
                Application.ExitThread();
            }

            DialogResult dr = MessageBox.Show(uName + "歡迎您!", "歡迎", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            Text = uName;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("感謝使用程式!", "感謝", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int w = Convert.ToInt32(TxtW.Text);
                int h = Convert.ToInt32(TxtH.Text);
                LblArea.Text = Convert.ToString(w * h * 0.3025) + " 坪";
            }
            catch
            {
                MessageBox.Show("請輸入寬和長度!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感謝使用程式!", "感謝", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}