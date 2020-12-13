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
    public partial class UserAdd : System.Web.UI.Page
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "新增用户";
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
                string sql = "insert into denglu(code,password,name,sex,birthday) values(@code,@pwd,@name,@sex,@birthday)";
                parameters.Add(new SqlParameter("@code", code));
                parameters.Add(new SqlParameter("@pwd", pwd));
                parameters.Add(new SqlParameter("@name", name));
                parameters.Add(new SqlParameter("@sex", sex));
                parameters.Add(new SqlParameter("@birthday", birthday));

                int ret = Sql.ExecuteSql(sql, parameters.ToArray());
                if (ret > 0)
                {
                    Response.Write("<script>alert('新增用户信息成功');window.location.href='UserList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('新增用户信息失败');</script>");
                }
            }
        }
    }
}