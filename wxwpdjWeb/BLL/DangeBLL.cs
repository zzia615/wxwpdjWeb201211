using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wxwpdjWeb.BLL
{
    public class DangeBLL
    {
        Utils.SqlFactoryUtil Sql = new Utils.SqlFactoryUtil();
        public DataTable GetDangerList(string name, string xdz_name, string xdz_sfzh, string catagory)
        {
            return new DAL.DangeDAL().GetDangerList(name, xdz_name, xdz_sfzh, catagory);
        }

        public DataTable GetDangerList(int id)
        {
            return new DAL.DangeDAL().GetDangerList(id);
        }


        public int AddDanger(string name, string xdz_name, string xdz_sex, string xdz_phone, string xdz_sfzh, string catagory, string remark)
        {

            return new DAL.DangeDAL().AddDanger(name, xdz_name, xdz_sex, xdz_phone, xdz_sfzh, catagory, remark);
        }


        public int EditDanger(int id, string name, string xdz_name, string xdz_sex, string xdz_phone, string xdz_sfzh, string catagory, string remark)
        {
            return new DAL.DangeDAL().EditDanger(id, name, xdz_name, xdz_sex, xdz_phone, xdz_sfzh, catagory, remark);
        }


        public int DeleteDanger(int id)
        {
            return new DAL.DangeDAL().DeleteDanger(id);
        }
    }
}