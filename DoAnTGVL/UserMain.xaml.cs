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
        private UserControl PreUC;
        private UserControl CurUC;
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
            CurUC = new UCThueTho();
            gridMain.Children.Remove(PreUC);
            Grid.SetColumn(CurUC, 1);
            PreUC = CurUC;
            gridMain.Children.Add(CurUC);
        }

        private void MnuTheoDoiBaiDang_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCTheoDoiBaiDang();
            gridMain.Children.Remove(PreUC);
            Grid.SetColumn(CurUC, 1);
            PreUC = CurUC;
            gridMain.Children.Add(CurUC);
        }

        private void TrangChuUser_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCTrangChu();
            gridMain.Children.Remove(PreUC);
            Grid.SetColumn(CurUC, 1);
            PreUC = CurUC;
            gridMain.Children.Add(CurUC);
        }
    }
}
