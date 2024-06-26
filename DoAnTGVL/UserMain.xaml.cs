﻿using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
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
        private UserControl PreUC = new UCHome();
        private UserControl CurUC = new UCHome();
        DAOTho dAOTho = new DAOTho();
        User user;
        public UserMain(User user)
        {
            this.user = user;
            InitializeComponent();
            gridMainWin.Children.Add(CurUC);


        }
        public void MnuLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MnuTheoDoiBaiDang_Click(object sender, RoutedEventArgs e)
        {
            gridMainWin.Background = Brushes.White;

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

        private void MnTrangChu_Click(object sender, RoutedEventArgs e)
        {
            gridMainWin.Children.Clear();
            CurUC = new UCHome();
            gridMainWin.Children.Add(CurUC);
        }
        private void MnuTimTho_Click(object sender, RoutedEventArgs e)
        {

            gridMainWin.Children.Clear();
            CurUC = new UCThueTho(user);
            gridMainWin.Children.Add(CurUC);
<<<<<<< HEAD
        }
=======
        }  
>>>>>>> dcdd0e647d99d26e9c401c009a5a7ab8037656e2
        private void MnuDanhGia_Click(object sender, RoutedEventArgs e)
        {
            DanhGiaTho danhGiaTho = new DanhGiaTho();
            this.Hide();
            danhGiaTho.ShowDialog();
            this.Show();
        }
    }
}
