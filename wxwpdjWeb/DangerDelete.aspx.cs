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
    public partial class DangerDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "删除教师";
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    DataTable table = new BLL.DangeBLL().GetDangerList(id.AsInt());
                    if (table != null && table.Rows.Count > 0)
                    {
                        tbId.Text = table.Rows[0]["id"].AsString();
                        tbName.Text = table.Rows[0]["name"].AsString();
                        tbXdzName.Text = table.Rows[0]["xdz_name"].AsString();
                        tbXdzSex.Text = table.Rows[0]["xdz_sex"].AsString();
                        tbXdzPhone.Text = table.Rows[0]["xdz_phone"].AsString();
                        tbXdzSfzh.Text = table.Rows[0]["xdz_sfzh"].AsString();
                        tbCatagory.Text = table.Rows[0]["catagory"].AsString();
                        tbRemark.Text = table.Rows[0]["remark"].AsString();
                    }
                    else
                    {
                        Response.Write("<script>alert('危险物品信息不存在');window.location.href='DangerList.aspx'</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('危险物品信息不存在');window.location.href='DangerList.aspx'</script>");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = tbId.Text.AsInt();

            if (Page.IsValid)
            {
                int ret = new BLL.DangeBLL().DeleteDanger(id);
                if (ret>0)
                {
                    Response.Write("<script>alert('删除危险物品信息成功');window.location.href='DangerList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除危险物品信息失败');</script>");
                }
            }
        }
    }
}