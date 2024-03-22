using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class Filter : INotifyPropertyChanged
    {
        private string khuVuc = "";
        private string kinhNghiem = "";
        private string ten = "";

        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public string Ten { get => ten; set { ten = value; OnPropertyChanged("Ten"); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        virtual public bool checkemp()
        {
            if(khuVuc == "" && kinhNghiem == "" && Ten=="")
                return true;
            return false;
        }

        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        virtual public void reset()
        {
            KhuVuc = "";
            KinhNghiem = "";
            Ten = "";
        }
    }
}
