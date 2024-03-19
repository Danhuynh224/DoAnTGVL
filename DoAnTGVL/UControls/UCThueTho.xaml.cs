using DoAnTGVL.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for UCThueTho.xaml
    /// </summary>
    public partial class UCThueTho : UserControl
    {
      
        public UCThueTho()
        {
           
            InitializeComponent();
   
        }

        private void click_DangBai(object sender, RoutedEventArgs e)
        {
            Window dangbai = new DangBai();
            dangbai.ShowDialog();
        }
        private void AddUserControl()
        {
            //UCDanhSachTho userControl = new UCDanhSachTho();
            //userControl.Width =280;
            //userControl.Height = 450;
            //userControl.Margin = new Thickness(10);
            //// Thêm UserControl vào WrapPanel
            //WpanelDanhS.Children.Add(userControl);
        }


    }
}
