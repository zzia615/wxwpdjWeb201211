using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wxwpdjWeb.DAL
{
    public class UserDAL
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        public DataTable GetUserList(string code,string name,string sex)
        {
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            //查询登录信息
            string sql = "select * from denglu where 1=1";

            if (!string.IsNullOrWhiteSpace(code))
            {
                sql += " and code=@code";
                parameters.Add(new SqlParameter("@code", code));
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                sql += " and name like @name";
                parameters.Add(new SqlParameter("@name", "%" + name + "%"));
            }

            if (!string.IsNullOrWhiteSpace(sex))
            {
                sql += " and sex=@sex";
                parameters.Add(new SqlParameter("@sex", sex));
            }
            //查询数据
            DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];

            return table;
        }

        public int AddUser(string code, string pwd, string name, string sex, string birthday)
        {
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            string sql = "insert into denglu(code,password,name,sex,birthday) values(@code,@pwd,@name,@sex,@birthday)";
            parameters.Add(new SqlParameter("@code", code));
            parameters.Add(new SqlParameter("@pwd", pwd));
            parameters.Add(new SqlParameter("@name", name));
            parameters.Add(new SqlParameter("@sex", sex));
            parameters.Add(new SqlParameter("@birthday", birthday));

            return Sql.ExecuteSql(sql, parameters.ToArray());
        }


        public int EditUser(string code, string pwd, string name, string sex, string birthday)
        {
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            string sql = "update denglu set password=@pwd,name=@name,sex=@sex,birthday=@birthday where code=@code";
            parameters.Add(new SqlParameter("@code", code));
            parameters.Add(new SqlParameter("@pwd", pwd));
            parameters.Add(new SqlParameter("@name", name));
            parameters.Add(new SqlParameter("@sex", sex));
            parameters.Add(new SqlParameter("@birthday", birthday));

            return Sql.ExecuteSql(sql, parameters.ToArray());
        }


        public int DeleteUser(string code)
        {
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            string sql = "delete from denglu where code=@code";
            parameters.Add(new SqlParameter("@code", code));

            return Sql.ExecuteSql(sql, parameters.ToArray());
        }
    }
}