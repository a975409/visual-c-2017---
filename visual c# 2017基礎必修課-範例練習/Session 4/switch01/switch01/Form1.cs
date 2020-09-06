using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblIncome.Text = "1.全年淨所得：";
            LblGrade.Text = "2.級     距：";
            LblTaxRate.Text = "3.所得稅率：";
            LblDiscount.Text = "4.累進差額：";
            LblTax.Text = "應繳稅額：";
            //TxtNetIncome.Text = "請輸入...";
            LblMsg.Text = "提示訊息：";
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            try
            {
                double netincome = Convert.ToInt32(TxtNetIncome.Text);
                int grade = netincome <= 520000 ? 1 : netincome <= 1170000 ? 2 : netincome <= 2350000 ? 3 : netincome <= 4400000 ? 4 : netincome <= 10000000 ? 5 : 6;
                double TaxRate = 0;
                double Discount = 0;
                double Tax = 0;

                switch (grade)
                {
                    case 1:
                        TaxRate = 0.05;
                        Discount = 0;
                        break;
                    case 2:
                        TaxRate = 0.12;
                        Discount = 36400;
                        break;
                    case 3:
                        TaxRate = 0.2;
                        Discount = 130000;
                        break;
                    case 4:
                        TaxRate = 0.3;
                        Discount = 365000;
                        break;
                    case 5:
                        TaxRate = 0.4;
                        Discount = 805000;
                        break;
                    case 6:
                        TaxRate = 0.45;
                        Discount = 1305000;
                        break;
                    default:
                        break;
                }

                if(netincome<0)
                {
                    LblMsg.Text += "***不能扣稅***";
                }
                else
                {
                    LblGrade.Text += grade.ToString();
                    LblTaxRate.Text += (TaxRate * 100) + "%";
                    LblDiscount.Text += Discount + "元";
                    Tax = netincome * TaxRate - Discount;
                    LblTax.Text += Tax + "元";
                    LblMsg.Text += "綜合所得淨額 X 稅率 - 累進差額";
                }
            }
            catch
            {
                LblMsg.Text += "請輸入所得淨額";
            }

            
        }

        private void TxtNetIncome_Enter(object sender, EventArgs e)
        {
            TxtNetIncome.Clear();
        }
    }
}
