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
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
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
                List<IDbDataParameter> parameter = new List<IDbDataParameter>();
                string sql = "insert into dangerInfo(name,xdz_name,xdz_sex,xdz_phone,xdz_sfzh,catagory,remark) values(@name,@xdz_name,@xdz_sex,@xdz_phone,@xdz_sfzh,@catagory,@remark)";
                parameter.Add(new SqlParameter("@name", name));
                parameter.Add(new SqlParameter("@xdz_name", xdz_name));
                parameter.Add(new SqlParameter("@xdz_sex", xdz_sex));
                parameter.Add(new SqlParameter("@xdz_phone", xdz_phone));
                parameter.Add(new SqlParameter("@xdz_sfzh", xdz_sfzh));
                parameter.Add(new SqlParameter("@catagory", catagory));
                parameter.Add(new SqlParameter("@remark", remark));

                int ret = Sql.ExecuteSql(sql, parameter.ToArray());
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