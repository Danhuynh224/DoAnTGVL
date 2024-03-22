using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class FilterTho : Filter
    {
        private float danhGia = 0;
        private string chuyenMon = "";
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override bool checkemp()
        {
            if (KhuVuc == "" && KinhNghiem == "" && danhGia == 0 && chuyenMon == "" && Ten =="")
                return true;
            return false;
        }
        public void reset()
        {
            KhuVuc = "";
            KinhNghiem = "";
            danhGia = 0;
            chuyenMon = "";
            Ten = "";
        }    
        
            
    }
}
