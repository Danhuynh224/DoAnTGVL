using DoAnTGVL.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace DoAnTGVL.DAO
{
    
    public class DAOTho

    {
        DbConection dbConection =new DbConection();
        public List<Tho> ReadAllTho()
        {        
            string query = "Select * From Tho";
            return dbConection.ReadDatabase(query);
        }
        public List<Tho> FilterTho(FilterTho filterTho)
        {
            string query = "Select * From Tho";
            if (!filterTho.checkemp()) {
                query += " Where";
                if (filterTho.KhuVuc != "")
                {
                    query += string.Format(" KhuVuc = N'{0}'", filterTho.KhuVuc);
                }
                if (filterTho.KinhNghiem !="")
                {
                    if (filterTho.KhuVuc != "")
                        query += " and";
                    query += string.Format(" KinhNghiem = N'{0}'", filterTho.KinhNghiem);
                }
                if (filterTho.DanhGia != 0)
                {
                    if (filterTho.KhuVuc != "" || filterTho.KinhNghiem != "")
                        query += " and";
                    query += string.Format(" DanhGia  >= {0}", filterTho.DanhGia);
                }
                if (filterTho.ChuyenMon !="")
                {
                    if (filterTho.KhuVuc != "" || filterTho.KinhNghiem != "" || filterTho.DanhGia != 0)
                        query += " and";
                    query += string.Format(" ChuyenMon = N'{0}'", filterTho.ChuyenMon);
                }    
            }
            return dbConection.ReadDatabase(query);
        }
    }
}
