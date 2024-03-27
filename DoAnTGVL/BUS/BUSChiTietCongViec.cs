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
        public void Them(BaiDang baiDang, Tho tho)
        {
            if(dAODSCongViec.CheckNgayBan(baiDang.DateThue,tho.Id))
            {
                dAODSCongViec.ThoThem(baiDang, tho);
            }
            else
            {
                MessageBox.Show("Ngày đó bạn bận!!!");
            }    
        }
    }
}
