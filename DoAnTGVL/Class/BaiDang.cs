using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class BaiDang
    {
        private string iD;
        private string iDUser;
        private string tieuDe;
        private string khuVuc;
        private string moTa;
        private DateTime date;
        private string kinhNghiem;
        private string ghiChu;
        private string yeuCau;

        public BaiDang(string iD, string iDUser, string tieuDe, string khuVuc, string moTa, DateTime date, string kinhNghiem, string yeuCau ,string ghiChu)
        {
            this.ID = iD;
            this.IDUser = iDUser;
            this.TieuDe = tieuDe;
            this.KhuVuc = khuVuc;
            this.MoTa = moTa;
            this.Date = date;
            this.KinhNghiem = kinhNghiem;
            this.GhiChu = ghiChu;
            this.YeuCau = yeuCau;
        }

        public string ID { get => iD; set => iD = value; }
        public string IDUser { get => iDUser; set => iDUser = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public DateTime Date { get => date; set => date = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
    }
}
