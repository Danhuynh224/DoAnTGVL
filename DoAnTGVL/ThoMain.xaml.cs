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
    /// 

    public partial class ThoMain : Window
    {
        private UserControl PreUC;
        private UserControl CurUC;
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

            CurUC =new UCSuaCV();
            gridMain.Children.Remove(PreUC);
            PreUC = CurUC;
            Grid.SetColumn(CurUC, 1);      
            gridMain.Children.Add(CurUC);
        }
       public void mnuTimViec_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCTimViec();
            gridMain.Children.Remove(PreUC);
            PreUC = CurUC;
            Grid.SetColumn(CurUC, 1);
            gridMain.Children.Add(CurUC);
        }
        public void mnuViecLam_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCCViecTho();
            gridMain.Children.Remove(PreUC);
            PreUC = CurUC;
            Grid.SetColumn(CurUC, 1);
            gridMain.Children.Add(CurUC);
        }
        public void mnuViewwDG_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCViewDG();
            gridMain.Children.Remove(PreUC);
            PreUC = CurUC;
            Grid.SetColumn(CurUC, 1);
            gridMain.Children.Add(CurUC);
        }
    }
}
