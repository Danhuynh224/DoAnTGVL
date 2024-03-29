using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.DAO
{
    public class DAODSCongViec
    {
        DbConection dbConection = new DbConection();
        public List<DateTime> TimNgayBan(int idTho)
        {
            string query = string.Format("Select * From DSCongViec Where IDTho = {0}",idTho);
            return dbConection.ReadDatabaseNgayBan(query);
        }
        public void Them(CongViec congViec)
        {

            string sqlString = string.Format("INSERT INTO DSCongViec ( IDTho, IDUser, TieuDe, MoTa, LinhVuc, KhuVuc, DateThue, TrangThai) VALUES ({0}, {1}, N'{2}', N'{3}',N'{4}',N'{5}','{6}', N'{7}')", congViec.IDTho, congViec.IDUser,
                congViec.TieuDe, congViec.MoTa, congViec.LinhVuc,congViec.KhuVuc ,congViec.DateThue.ToShortDateString(), congViec.TrangThai);
            dbConection.Process(sqlString);
            MessageBox.Show("Sucessfully");
        }
        public void ThoThem(BaiDang baiDang, Tho tho)
        {
            string sqlString = string.Format("INSERT INTO DSCongViec ( IDTho, IDUser, TieuDe, MoTa, LinhVuc, KhuVuc, DateThue, TrangThai) VALUES ({0}, {1}, N'{2}', N'{3}',N'{4}',N'{5}','{6}', N'{7}')", tho.Id, baiDang.IDUser,
              baiDang.TieuDe, baiDang.MoTa, baiDang.LinhVuc, baiDang.KhuVuc, baiDang.DateThue.ToShortDateString(), "Đã xác nhận");
            dbConection.Process(sqlString);
            MessageBox.Show("Sucessfully"); 
        }
        public bool CheckNgayBan(DateTime date, int idTho)
        {
            string queryString = string.Format("SELECT * FROM DSCongViec WHERE DateThue = '{0}' and IDTho = {1}", date, idTho);
            return dbConection.CheckExist(queryString);
        }

        public List<CongViec> ReadAllCongViec(int id)
        {
            string query =string.Format("Select * From DSCongViec Where IDTho = {0}",id);
            return dbConection.ReadDatabaseCongViec(query);
        }
    }
}
