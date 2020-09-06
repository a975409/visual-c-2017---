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



namespace ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        DataSet ds;
        DataTable dt;
        // 宣告index用來記錄目前資料記錄位置，0表示第一筆，1表示第二筆
        int index = 0;

        void ShowData()
        {
            txtId.Text = dt.Rows[index]["學號"].ToString(); 
            txtName.Text = dt.Rows[index]["姓名"].ToString(); 
            txtChi.Text = dt.Rows[index]["國文"].ToString(); 
            txtEng.Text = dt.Rows[index]["英文"].ToString();
            txtMath.Text = dt.Rows[index]["數學"].ToString();
            lblShow.Text = "第" + (index + 1) + "筆,共" + dt.Rows.Count + "筆";
        }


        String cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True;Connect Timeout=30";


        private void Form1_Load(object sender, EventArgs e)
        {


            SqlConnection cn = new SqlConnection(cnStr);

            SqlDataAdapter da = new SqlDataAdapter
                 ("SELECT * FROM 學生", cn);
            // 建立DataSet物件ds
            ds = new DataSet();
            da.Fill(ds);
            // 將ds內的第一個DataTable物件指定給DataTable物件dt
            dt = ds.Tables[0];
            // 呼叫ShowData方法將DataTable指定某筆DataRow顯示在文字方塊中
            ShowData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;  
                     
            if (index < 0)
            {
                index = dt.Rows.Count - 1;
            }
            ShowData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;  //往下移一筆
                      // 若index大於筆於DataTable的筆數，即指定index指向第一筆
            if (index >= dt.Rows.Count)
            {
                index = 0;
            }
            ShowData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = dt.Rows.Count - 1;
            ShowData();
        }
    }
}
