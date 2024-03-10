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

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCDanhSachTho.xaml
    /// </summary>
    public partial class UCDanhSachTho : UserControl
    {
        public UCDanhSachTho()
        {
            InitializeComponent();
        }
        public void btnXemChiTiet_Click(object sender, RoutedEventArgs e)
        {
            ChiTietTho chiTietTho = new ChiTietTho();
            chiTietTho.Show();

        }
    }
}
