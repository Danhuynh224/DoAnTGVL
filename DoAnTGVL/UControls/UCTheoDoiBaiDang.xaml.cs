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
    /// Interaction logic for UCTheoDoiBaiDang.xaml
    /// </summary>
    public partial class UCTheoDoiBaiDang : UserControl
    {
        public UCTheoDoiBaiDang()
        {
            InitializeComponent();
        }

        private void ThemBaiDang_Click(object sender, RoutedEventArgs e)
        {
            DangBai db = new();
            db.ShowDialog();
        }
    }
}
