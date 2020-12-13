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
    public partial class DangerList : System.Web.UI.Page
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as MainSite).PageTitle = "危险物品信息";
            if (!IsPostBack)
            {
                Button1_Click(null, null);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from dangerInfo where 1=1";

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                sql += " and name like @name";
                parameters.Add(new SqlParameter("@name", "%"+tbName.Text+"%"));
            }

            if (!string.IsNullOrWhiteSpace(tbXdzName.Text))
            {
                sql += " and xdz_name like @xdz_name";
                parameters.Add(new SqlParameter("@xdz_name", "%" + tbXdzName.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(tbXdzSfzh.Text))
            {
                sql += " and xdz_sfzh like @xdz_sfzh";
                parameters.Add(new SqlParameter("@xdz_sfzh", "%" + tbXdzSfzh.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(tbCatagory.Text))
            {
                sql += " and catagory like @catagory";
                parameters.Add(new SqlParameter("@catagory", "%" + tbCatagory.Text + "%"));
            }

            DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}