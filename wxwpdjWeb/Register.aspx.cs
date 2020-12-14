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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "用户注册";
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
                int ret = new BLL.UserBLL().AddUser(code, pwd, name, sex, birthday);
                if (ret > 0)
                {
                    Response.Write("<script>alert('用户信息注册成功');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户信息注册失败');</script>");
                }
            }
        }
    }
}