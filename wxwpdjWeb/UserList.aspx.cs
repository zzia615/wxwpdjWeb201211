using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxwpdjWeb
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as MainSite).PageTitle = "用户信息";
            if (!IsPostBack)
            {
                Button1_Click(null, null);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //查询数据
            DataTable table = new BLL.UserBLL().GetUserList(tbCode.Text, tbName.Text, DropDownList1.Text);
            //设置数据源
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}