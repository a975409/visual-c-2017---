using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex16_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["編號"].DefaultValue = txtNo.Text;
            SqlDataSource1.InsertParameters["姓名"].DefaultValue = txtName.Text;
            SqlDataSource1.InsertParameters["性別"].DefaultValue = txtSex.Text;
            SqlDataSource1.InsertParameters["電話"].DefaultValue = txtTel.Text;
            SqlDataSource1.Insert();
            btnCls_Click(sender, e);
        }

        protected void btnCls_Click(object sender, EventArgs e)
        {
            txtNo.Text = "";
            txtName.Text = "";
            txtSex.Text = "";
            txtTel.Text = "";
        }
    }
}