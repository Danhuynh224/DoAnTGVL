using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class Tho:User
    {
        private string kinhnghiem;
        private string linhVuc;
        private string chuyenMon;
        private int giatien;
        private float danhGia;

        public Tho(string id, string hoTen, string cCCD, string sDT, DateTime dob, string khuvuc,string linhvuc,string chuyenmon, string kinhnghiem, int giatien,float danhgia) : base(id, hoTen, cCCD, sDT, dob, khuvuc)
        {
            this.linhVuc = linhvuc;
            this.chuyenMon = chuyenmon;
            this.giatien = giatien;
            this.danhGia = danhgia;
            this.Kinhnghiem= kinhnghiem;
        }

        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public int Giatien { get => giatien; set => giatien = value; }
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public string Kinhnghiem { get => kinhnghiem; set => kinhnghiem = value; }
    }
}
