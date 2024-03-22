using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
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

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCTimViec.xaml
    /// </summary>
    public partial class UCTimViec : UserControl
    {
        BUSTimViec bustimviec = new BUSTimViec();
        DAOBaiDang daobaidang = new DAOBaiDang();
        FilterBaiDang filterBaiDang=new FilterBaiDang();
        public UCTimViec()
        {
            InitializeComponent();
            this.DataContext = filterBaiDang;
            bustimviec.CreateWrapBaiDang(filterBaiDang, this);
        }

        private void fil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filterBaiDang.KhuVuc = (cboKhuVuc.SelectedItem != null) ? (cboKhuVuc.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterBaiDang.KinhNghiem = (cboKinhNghiem.SelectedItem != null) ? (cboKinhNghiem.SelectedItem as ComboBoxItem).Content.ToString() : "";
            bustimviec.CreateWrapBaiDang(filterBaiDang, this); ;
        }
        private void btnUploadProfile_Click(object sender, RoutedEventArgs e)
        {
            Window profile = new ProfileTho();
            profile.Show();
        }
        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show(filterBaiDang.Ten);
            bustimviec.CreateWrapBaiDang(filterBaiDang, this);
        }
    }

}
