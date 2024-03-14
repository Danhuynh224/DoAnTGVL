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
using System.Diagnostics;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void click_DangNhap(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window window;
            if (rdbKhach.IsChecked==true)
            {
                window = new UserMain();
                window.ShowDialog();
            }
            else if(rdbTho.IsChecked == true)
            {
                window = new ThoMain();
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
