using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wxwpdjWeb.BLL
{
    public class UserBLL
    {
        public DataTable GetUserList(string code,string name,string sex)
        {
            return new DAL.UserDAL().GetUserList(code, name, sex);
        }

        public int AddUser(string code,string pwd,string name,string sex, string birthday)
        {
            return new DAL.UserDAL().AddUser(code, pwd, name, sex, birthday);
        }


        public int EditUser(string code, string pwd, string name, string sex, string birthday)
        {
            return new DAL.UserDAL().EditUser(code, pwd, name, sex, birthday);
        }
        public int DeleteUser(string code)
        {
            return new DAL.UserDAL().DeleteUser(code);
        }
    }
}