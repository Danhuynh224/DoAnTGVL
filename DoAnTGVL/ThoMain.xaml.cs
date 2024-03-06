using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for ThoMain.xaml
    /// </summary>
    public partial class ThoMain : Window
    {
        public ThoMain()
        {
            InitializeComponent();
        }
        public void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void mnuSuaCV_Click(object sender, RoutedEventArgs e)
        {
            
            UCSuaCV uCSuaCV =new UCSuaCV();
            Grid.SetColumn(uCSuaCV, 1);
            gridMain.Children.Add(uCSuaCV);
        }
    }
}
