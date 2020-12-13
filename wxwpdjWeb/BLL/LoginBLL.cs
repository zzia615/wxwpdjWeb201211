using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace wxwpdjWeb.BLL
{
    public class LoginBLL
    {
        public DataTable GetUser(string code,string pwd)
        {
            return new DAL.LoginDAL().GetUser(code, pwd);
        }
    }
}