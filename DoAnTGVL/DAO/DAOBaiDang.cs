using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.DAO
{
    class DAOBaiDang
    {
        DbConection dbConection = new DbConection();
        public List<BaiDang> ReadAllBaiDang()
        {
            string query = "Select * From BaiDang";
            return dbConection.ReadDatabaseBaiDang(query);
        }
    }
}
