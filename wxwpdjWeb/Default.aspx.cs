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
    public partial class Default : System.Web.UI.Page
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "用户登录";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            string pwd = tbPwd.Text;

            if (Page.IsValid)
            {
                List<IDbDataParameter> parameters = new List<IDbDataParameter>();
                string sql = "select * from denglu where code=@code and password=@pwd";
                parameters.Add(new SqlParameter("@code", code));
                parameters.Add(new SqlParameter("@pwd", pwd));

                DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];
                if (table != null && table.Rows.Count > 0)
                {
                    Response.Write("<script>alert('登录成功');window.location.href='Home.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('账号密码输入有误，请重试');window.location.href='Default.aspx'</script>");
                }
            }
        }
    }
}