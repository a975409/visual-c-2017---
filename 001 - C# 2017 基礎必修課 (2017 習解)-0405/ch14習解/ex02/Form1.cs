using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True;Connect Timeout=30";


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnStr);           // 建立SqlConnection物件cn
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From 學生", cn);
            DataSet ds = new DataSet();    // 建立DataSet物件ds
            da.Fill(ds);                     
            dataGridView1.DataSource = ds.Tables[0];  

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {               // 使用例外處理來補捉新增資料時會發生的例外
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();  // 建立SqlCommand物件cmd
                                                    // 設定SQL的INSERT新增命令
                cmd.CommandText =
                  "INSERT INTO 學生(學號,姓名,國文,英文,數學)VALUES(N'" +
                  txtId.Text.Replace("'", "''") + "',N'" +
                  txtName.Text.Replace("'", "''") + "'," +
                  txtChi.Text + "," +
                  txtEng.Text + "," +
                  txtMath.Text + ")";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();         // cmd物件執行SQL的INSERT新增命令
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try    // 使用例外處理來補捉修改資料時會發生的例外
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                // 設定SQL的UPDATE修改命令
                cmd.CommandText = "UPDATE 學生 SET 姓名=N'" +
                  txtName.Text.Replace("'", "''") + "', 國文=" +
                  txtChi.Text + ", 英文=" +
                  txtEng.Text + ", 數學=" +
                  txtMath.Text + " WHERE 學號=N'" +
                  txtId.Text.Replace("'", "''") + "'";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try    // 使用例外處理來補捉刪除資料時會發生的例外
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                // 設定SQL的DELETE刪除命令
                cmd.CommandText = "DELETE FROM 學生 WHERE 學號=N'" +
                  txtId.Text.Replace("'", "''") + "'";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
