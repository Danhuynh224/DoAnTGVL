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
            PreUC = null;
            InitializeComponent();
        }
        public void MnuLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void MnuThueTho_Click(object sender, RoutedEventArgs e)
            
        {
            gridMainWin.Background = Brushes.White;
            CurUC = new UCThueTho();
            gridMainWin.Children.Remove(PreUC);

            PreUC = CurUC;
            gridMainWin.Children.Add(CurUC);
        }

        private void MnuTheoDoiBaiDang_Click(object sender, RoutedEventArgs e)
        {
            gridMainWin.Background = Brushes.White;
            CurUC = new UCTheoDoiBaiDang();
            gridMainWin.Children.Remove(PreUC);

            PreUC = CurUC;
            gridMainWin.Children.Add(CurUC);
        }

        private void TrangChuUser_Click(object sender, RoutedEventArgs e)
        {
            gridMainWin.Background = Brushes.White;
            CurUC = new UCTrangChu();
            gridMainWin.Children.Remove(PreUC);
            
            PreUC = CurUC;
            gridMainWin.Children.Add(CurUC);
        }

        private void MnuTienDo_Click(object sender, RoutedEventArgs e)
        {
            gridMainWin.Background = Brushes.White;
            CurUC = new UCTienDo();
            gridMainWin.Children.Remove(PreUC);
            
            PreUC = CurUC;
            gridMainWin.Children.Add(CurUC);
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;

        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;

        }

        private void gridMainmenu_MouseLeave(object sender, MouseEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
    }
}
