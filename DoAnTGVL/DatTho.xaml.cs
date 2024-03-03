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
    /// Interaction logic for DatTho.xaml
    /// </summary>
    public partial class DatTho : Window
    {
        public DatTho()
        {
            InitializeComponent();
        }
        public void click_Dat(object sender, RoutedEventArgs e)
        {

        }
        public void click_Huy(object sender, RoutedEventArgs e) { 
            this.Close();
        }
    }
}
