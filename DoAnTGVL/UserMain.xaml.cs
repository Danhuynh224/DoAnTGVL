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
        public void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void mnuThueTho_Click(object sender, RoutedEventArgs e)
        {
            UCThueTho uCThueTho = new UCThueTho();
            Grid.SetColumn(uCThueTho, 1);
            gridMain.Children.Add(uCThueTho);
        }
        public void mnuDangBai_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
