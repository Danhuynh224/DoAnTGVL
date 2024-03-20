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
        public List<Tho> FilterTho(string pro, string condition)
        {
            string query = string.Format("Select * From Tho Where {0} = N'{1}'",pro,condition);
            return dbConection.ReadDatabase(query);
        }
    }
}
