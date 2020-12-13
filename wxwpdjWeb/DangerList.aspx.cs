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
            DataTable table = new BLL.DangeBLL().GetDangerList(tbName.Text, tbXdzName.Text, tbXdzSfzh.Text, tbCatagory.Text);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}