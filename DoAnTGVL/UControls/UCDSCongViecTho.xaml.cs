using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DoAnTGVL.DAO;
using DoAnTGVL.Class;
using DoAnTGVL.BUS;
using System.Collections.ObjectModel;

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCDSCongViecTho.xaml
    /// </summary>
    public partial class UCDSCongViecTho : UserControl
    {
        BUSChiTietCongViec buschitietcv = new BUSChiTietCongViec();
        public UCDSCongViecTho()
        {
            InitializeComponent();
            LoadDataIntoListView();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvDSCV.ItemsSource);

        }

        private void LoadDataIntoListView()
        {
            List<CongViec> dataList = buschitietcv.LoadData();
            lsvDSCV.ItemsSource = dataList;
        }
    }
}
