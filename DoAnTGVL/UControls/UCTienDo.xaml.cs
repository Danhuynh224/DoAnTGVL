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
    /// Interaction logic for UCTienDo.xaml
    /// </summary>
    public partial class UCTienDo : UserControl
    {
        private UserControl PreUC;
        private UserControl CurUC;
        public UCTienDo()
        {
            InitializeComponent();
        }

        private void DaHoanThanh_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCUserDaHoanThanh();
            GridContent.Children.Remove(PreUC);
            Grid.SetRow(CurUC, 1);
            PreUC = CurUC;
            GridContent.Children.Add(CurUC);
        }

        private void DangThucHien_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCUserDangThucHien();
            GridContent.Children.Remove(PreUC);
            Grid.SetRow(CurUC, 1);
            PreUC = CurUC;
            GridContent.Children.Add(CurUC);
        }

        private void ChuaThucHien_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCUserChuaThucHien();
            GridContent.Children.Remove(PreUC);
            Grid.SetRow(CurUC, 1);
            PreUC = CurUC;
            GridContent.Children.Add(CurUC);
        }
    }
}
