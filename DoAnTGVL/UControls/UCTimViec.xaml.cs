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
        List<BaiDang> DSbaidang;
        public UCTimViec()
        {
            InitializeComponent();
            DSbaidang = daobaidang.ReadAllBaiDang();
            bustimviec.CreateWrapBaiDang(DSbaidang, this);
        }
        //private void AddUserControl()
        //{


        //    UCDanhSachCongViec userControl = new UCDanhSachCongViec();
        //    userControl.Width = 620;
        //    userControl.Height = 370;
        //    userControl.Margin = new Thickness(10);

        //    // Thêm UserControl vào WrapPanel
        //    WpanelDanhS.Children.Add(userControl);
        //}

        private void btnUploadProfile_Click(object sender, RoutedEventArgs e)
        {
            Window profile = new ProfileTho();
            profile.Show();
        }
    }

}
