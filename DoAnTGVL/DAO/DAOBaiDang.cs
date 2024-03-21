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
            string sqlStr = string.Format("INSERT INTO BaiDang (ID, IDUser, TieuDe, KhuVuc, MoTa, Date, KinhNghiem, YeuCau, GhiChu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                    , baidang.ID, baidang.IDUser, baidang.TieuDe, baidang.KhuVuc, baidang.MoTa, baidang.Date.ToShortDateString(), baidang.KinhNghiem, baidang.YeuCau, baidang.GhiChu);
            dbConection.Process(sqlStr);
        }
    }
}
