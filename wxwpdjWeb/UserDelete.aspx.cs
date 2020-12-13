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
    public partial class UserDelete : System.Web.UI.Page
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "删除用户";
            if (!IsPostBack)
            {
                string code = Request.QueryString["code"];
                if (!string.IsNullOrEmpty(code))
                {
                    List<IDbDataParameter> parameters = new List<IDbDataParameter>();
                    string sql = "select * from denglu where code=@code";
                    parameters.Add(new SqlParameter("@code", code));

                    var table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];
                    if (table != null && table.Rows.Count > 0)
                    {
                        tbCode.Text = table.Rows[0]["code"].ToString();
                        tbPwd.Text = table.Rows[0]["password"].ToString();
                        tbName.Text = table.Rows[0]["name"].ToString();
                        tbSex.Text = table.Rows[0]["sex"].ToString();
                        tbBirtday.Text = DateTime.Parse(table.Rows[0]["birthday"].ToString()).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        Response.Write("<script>alert('用户信息不存在');window.location.href='UserList.aspx'</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('用户信息不存在');window.location.href='UserList.aspx'</script>");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            string pwd = tbPwd.Text;
            string sex = tbSex.Text;
            string name = tbName.Text;
            string birthday = tbBirtday.Text;

            if (Page.IsValid)
            {
                List<IDbDataParameter> parameters = new List<IDbDataParameter>();

                string sql = "delete from denglu where code=@code";
                parameters.Add(new SqlParameter("@code", code));

                int ret = Sql.ExecuteSql(sql,parameters.ToArray());
                if (ret>0)
                {
                    Response.Write("<script>alert('删除用户信息成功');window.location.href='UserList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除用户信息失败');</script>");
                }
            }
        }
    }
}