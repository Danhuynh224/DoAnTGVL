using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.BUS
{
    public class BUSChiTietCongViec
    {
        DAODSCongViec dAODSCongViec= new DAODSCongViec();
        DAOBaiDang dAOBaiDang = new DAOBaiDang();   
        public void Them(BaiDang baiDang, Tho tho)
        {
            if(dAODSCongViec.CheckNgayBan(baiDang.DateThue,tho.Id))
            {
                dAODSCongViec.ThoThem(baiDang, tho);
                dAOBaiDang.XoaBaiDang(baiDang);
            }
            else
            {
                MessageBox.Show("Ngày đó bạn bận!!!");
            }    
        }

        public List<CongViec> LoadData(int id)
        {
            return dAODSCongViec.ReadAllCongViec(id);
        }
    }
}
