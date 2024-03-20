using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class FilterTho
    {
        private string khuVuc="";
        private string kinhNghiem = "";
        private float danhGia = 0;
        private string chuyenMon = "";

        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }

        public bool checkemp()
        {
            if (khuVuc == "" && kinhNghiem == "" && danhGia == 0 && chuyenMon == "")
                return true;
            return false;
        }
    }
}
