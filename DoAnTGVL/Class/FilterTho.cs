using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class FilterTho : INotifyPropertyChanged
    {
        private string khuVuc="";
        private string kinhNghiem = "";
        private float danhGia = 0;
        private string chuyenMon = "";
        private string ten = "";

        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public string Ten { get => ten; set { ten = value; OnPropertyChanged("Ten");  } }

        public event PropertyChangedEventHandler? PropertyChanged;

        public bool checkemp()
        {
            if (khuVuc == "" && kinhNghiem == "" && danhGia == 0 && chuyenMon == "" && ten =="")
                return true;
            return false;
        }
        public void reset()
        {
            khuVuc = "";
            kinhNghiem = "";
            danhGia = 0;
            chuyenMon = "";
            ten = "";
        }    
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            } 
                
        }    
    }
}
