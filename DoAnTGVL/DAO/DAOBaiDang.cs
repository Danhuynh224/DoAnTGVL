using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
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

        public void Them(BaiDang baidang)
        {
            string sqlStr = string.Format("INSERT INTO BaiDang ( IDUser, TieuDe, LinhVuc, KhuVuc, MoTa, Date, KinhNghiem, YeuCau, GhiChu) VALUES ('{0}', N'{1}', N'{2}', N'{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}')"
                    , "100", baidang.TieuDe, baidang.LinhVuc, baidang.KhuVuc, baidang.MoTa, baidang.DateThue.ToShortDateString(), baidang.KinhNghiem, baidang.YeuCau, baidang.GhiChu);
            dbConection.Process(sqlStr);
        }
    }
}
