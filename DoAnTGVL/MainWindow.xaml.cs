﻿using System;
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
using System.Diagnostics;
using System.Data.SqlClient;
using DoAnTGVL.BUS;
using DoAnTGVL.Class;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
        TaiKhoan taikhoan= new TaiKhoan();
        BUSTaiKhoan bUSTaiKhoan = new BUSTaiKhoan();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = taikhoan;
        }
        public void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void click_DangNhap(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window window;
            if (rdbUser.IsChecked==true)
            {
                User user = new User(1, "Huỳnh Việt Đan", "099900134386", "08765678542",DateTime.Today, "Quận 1");
                window = new UserMain(user);
                window.ShowDialog();
                
            }
            else if(rdbTho.IsChecked == true)
            {
                Tho tho = new Tho(1, "Nguyễn Ngọc Hoàng", "099900134386", "08765678542", DateTime.Today, "Quận 1", "Điện lạnh", "Sửa máy lạnh", "1 - 2 năm", 500000,4);
                window = new ThoMain(tho);
                window.ShowDialog();
            }
            this.Show();

        }
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
                e.Handled = true;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

       
    }
}
