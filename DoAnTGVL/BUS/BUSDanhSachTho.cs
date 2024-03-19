using DoAnTGVL.Class;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.BUS
{
    public class BUSDanhSachTho
    {
       
        public UCDanhSachTho CreateDSTho(Tho tho)
        {
            UCDanhSachTho uCDanhSachTho = new UCDanhSachTho();
            uCDanhSachTho.txtKhucVuc.Text = tho.Khuvuc.ToString();
            uCDanhSachTho.txtName.Text=tho.HoTen.ToString();
            uCDanhSachTho.txtDanhGia.Text=tho.DanhGia.ToString()+ "/5";
            uCDanhSachTho.txtKinhNghiem.Text = tho.Kinhnghiem.ToString();
            uCDanhSachTho.txtChuyenMon.Text = tho.ChuyenMon.ToString();
            return uCDanhSachTho;
        }
        
    }
}
