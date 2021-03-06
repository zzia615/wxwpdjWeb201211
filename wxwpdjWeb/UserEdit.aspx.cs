﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxwpdjWeb
{
    public partial class UserEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "修改用户";
            if (!IsPostBack)
            {
                string code = Request.QueryString["code"];
                if (!string.IsNullOrEmpty(code))
                {
                    var table = new BLL.UserBLL().GetUserList(code,"","");
                    if (table!=null&& table.Rows.Count>0)
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

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            //查询登录信息
            if (Page.IsValid)
            {
                int ret = new BLL.UserBLL().EditUser(code,pwd,name,sex,birthday);
                if (ret>0)
                {
                    Response.Write("<script>alert('修改用户信息成功');window.location.href='UserList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改用户信息失败');</script>");
                }
            }
        }
    }
}