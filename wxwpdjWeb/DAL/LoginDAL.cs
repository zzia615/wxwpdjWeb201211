using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wxwpdjWeb.DAL
{
    public class LoginDAL
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        public DataTable GetUser(string code,string pwd)
        {

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            string sql = "select * from denglu where code=@code and password=@pwd";
            parameters.Add(new SqlParameter("@code", code));
            parameters.Add(new SqlParameter("@pwd", pwd));

            DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];

            return table;
        }
    }
}