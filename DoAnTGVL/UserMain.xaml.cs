using DoAnTGVL.UControls;
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
using System.Windows.Shapes;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for UserMain.xaml
    /// </summary>
    public partial class UserMain : Window
    {
        public UserMain()
        {
            InitializeComponent();
        }
        public void MnuLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void MnuThueTho_Click(object sender, RoutedEventArgs e)
        {
            UCThueTho uCThueTho = new();
            Grid.SetColumn(uCThueTho, 1);
            gridMain.Children.Add(uCThueTho);
        }

        private void MnuTheoDoiBaiDang_Click(object sender, RoutedEventArgs e)
        {
            UCTheoDoiBaiDang ucTheoDoi = new();
            Grid.SetColumn(ucTheoDoi, 1);
            gridMain.Children.Add(ucTheoDoi);
        }

        private void TrangChuUser_Click(object sender, RoutedEventArgs e)
        {
            UCTrangChu uCTrangChu = new();
            Grid.SetColumn(uCTrangChu, 1);
            gridMain.Children.Add(uCTrangChu);
        }
    }
}
