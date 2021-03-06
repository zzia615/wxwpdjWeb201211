﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxwpdjWeb
{
    public partial class EditSite : System.Web.UI.MasterPage
    {
        public string PageTitle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果用户未登录则返回登录页面
            if (string.IsNullOrEmpty(Session["登录账号"].AsString())&&(PageTitle!= "用户登录"&& PageTitle != "用户注册"))
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}