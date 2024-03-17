using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    class BaiDang
    {
        private string iD;
        private string iDUser;
        private string tieuDe;
        private string khuVuc;
        private string moTa;
        private DateTime date;
        private string kinhNghiem;
        private string ghiChu;

        public BaiDang(string iD, string iDUser, string tieuDe, string khuVuc, string moTa, DateTime date, string kinhNghiem, string ghiChu)
        {
            this.iD = iD;
            this.iDUser = iDUser;
            this.tieuDe = tieuDe;
            this.khuVuc = khuVuc;
            this.moTa = moTa;
            this.date = date;
            this.kinhNghiem = kinhNghiem;
            this.ghiChu = ghiChu;
        }
    }
}
