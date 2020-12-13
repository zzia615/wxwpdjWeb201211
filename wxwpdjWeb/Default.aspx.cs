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
        protected void Page_Load(object sender, EventArgs e)
        {
            //清会话
            Session.Clear();
            (this.Master as EditSite).PageTitle = "用户登录";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            string pwd = tbPwd.Text;

            if (Page.IsValid)
            {
                DataTable table = new BLL.LoginBLL().GetUser(code,pwd);
                if (table != null && table.Rows.Count > 0)
                {
                    //缓存登录账号
                    Session["登录账号"] = table.Rows[0]["code"].AsString();

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