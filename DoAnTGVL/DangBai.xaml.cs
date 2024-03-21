using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Shapes;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for DangBai.xaml
    /// </summary>
    public partial class DangBai : Window
    {
        BaiDang baidang;
        public DangBai(BaiDang baidang)
        {
            this.baidang = baidang;
            InitializeComponent();
            this.DataContext = baidang;
        }

        private void click_Huy(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_DangBai(object sender, RoutedEventArgs e)
        {
            try
            {
                //BaiDang baidang = new BaiDang("20", "1", );

            }
            catch
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }
    }
}
