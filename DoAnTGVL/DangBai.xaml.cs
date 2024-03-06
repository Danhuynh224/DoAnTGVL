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
    /// Interaction logic for DangBai.xaml
    /// </summary>
    public partial class DangBai : Window
    {
        public DangBai()
        {
            InitializeComponent();
        }

        private void click_Huy(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
