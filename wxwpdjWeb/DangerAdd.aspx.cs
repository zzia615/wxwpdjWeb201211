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
    public partial class DangerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "新增危险物品";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string xdz_name = tbXdzName.Text;
            string xdz_sex = tbXdzSex.Text;
            string xdz_phone = tbXdzPhone.Text;
            string xdz_sfzh = tbXdzSfzh.Text;
            string catagory = tbCatagory.Text;
            string remark = tbRemark.Text;


            if (Page.IsValid)
            {

                int ret = new BLL.DangeBLL().AddDanger(name, xdz_name, xdz_sex, xdz_phone, xdz_sfzh, catagory, remark);
                if (ret>0)
                {
                    Response.Write("<script>alert('登记危险物品成功');window.location.href='DangerList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('登记危险物品失败');</script>");
                }
            }
        }
    }
}