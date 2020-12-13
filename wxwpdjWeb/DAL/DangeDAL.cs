using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wxwpdjWeb.DAL
{
    public class DangeDAL
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        public DataTable GetDangerList(string name, string xdz_name, string xdz_sfzh,string catagory)
        {
            string sql = "select * from dangerInfo where 1=1";

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            if (!string.IsNullOrWhiteSpace(name))
            {
                sql += " and name like @name";
                parameters.Add(new SqlParameter("@name", "%" + name + "%"));
            }

            if (!string.IsNullOrWhiteSpace(xdz_name))
            {
                sql += " and xdz_name like @xdz_name";
                parameters.Add(new SqlParameter("@xdz_name", "%" + xdz_name + "%"));
            }

            if (!string.IsNullOrWhiteSpace(xdz_sfzh))
            {
                sql += " and xdz_sfzh like @xdz_sfzh";
                parameters.Add(new SqlParameter("@xdz_sfzh", "%" + xdz_sfzh + "%"));
            }

            if (!string.IsNullOrWhiteSpace(catagory))
            {
                sql += " and catagory like @catagory";
                parameters.Add(new SqlParameter("@catagory", "%" + catagory + "%"));
            }

            //查询数据
            DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];

            return table;
        }

        public DataTable GetDangerList(int id)
        {
            string sql = "select * from dangerInfo where 1=1";

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            sql += " and id = @id";
            parameters.Add(new SqlParameter("@id", id));
            //查询数据
            DataTable table = Sql.QueryDataSet(sql, parameters.ToArray()).Tables[0];

            return table;
        }


        public int AddDanger(string name, string xdz_name, string xdz_sex, string xdz_phone, string xdz_sfzh, string catagory, string remark)
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
            
            return Sql.ExecuteSql(sql, parameter.ToArray());
        }


        public int EditDanger(int id,string name, string xdz_name, string xdz_sex, string xdz_phone, string xdz_sfzh, string catagory, string remark)
        {
            List<IDbDataParameter> parameter = new List<IDbDataParameter>();

            string sql = "update dangerInfo set name=@name,xdz_name=@xdz_name,xdz_sex=@xdz_sex,xdz_phone=@xdz_phone,xdz_sfzh=@xdz_sfzh,catagory=@catagory,remark=@remark where id=@id";
            parameter.Add(new SqlParameter("@name", name));
            parameter.Add(new SqlParameter("@xdz_name", xdz_name));
            parameter.Add(new SqlParameter("@xdz_sex", xdz_sex));
            parameter.Add(new SqlParameter("@xdz_phone", xdz_phone));
            parameter.Add(new SqlParameter("@xdz_sfzh", xdz_sfzh));
            parameter.Add(new SqlParameter("@catagory", catagory));
            parameter.Add(new SqlParameter("@remark", remark));
            parameter.Add(new SqlParameter("@id", id));
            

            return Sql.ExecuteSql(sql, parameter.ToArray());
        }


        public int DeleteDanger(int id)
        {
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            string sql = "delete from dangerInfo where id=@id";
            parameters.Add(new SqlParameter("@id", id));


            return Sql.ExecuteSql(sql, parameters.ToArray());
        }
    }
}