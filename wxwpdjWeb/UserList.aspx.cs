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
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
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
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            //查询登录信息
            string sql = "select * from denglu where 1=1";
           
            if (!string.IsNullOrWhiteSpace(tbCode.Text))
            {
                sql += " and code=@code";
                parameters.Add(new SqlParameter("@code", tbCode.Text));
            }

            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                sql += " and name like @name";
                parameters.Add(new SqlParameter("@name", "%"+tbName.Text+"%"));
            }

            if (!string.IsNullOrWhiteSpace(DropDownList1.Text))
            {
                sql += " and sex=@sex";
                parameters.Add(new SqlParameter("@sex", DropDownList1.Text));
            }
            //查询数据
            DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];
            //设置数据源
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}