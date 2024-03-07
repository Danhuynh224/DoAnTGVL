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
<<<<<<<< HEAD:DoAnTGVL/UControls/UCSuaCV.xaml.cs
    /// Interaction logic for UCSuaCV.xaml
    /// </summary>
    public partial class UCSuaCV : UserControl
    {
        public UCSuaCV()
========
    /// Interaction logic for DangBai.xaml
    /// </summary>
    public partial class DangBai : Window
    {
        public DangBai()
>>>>>>>> 11f6a59c4ad024d8c3c52d9e64b168947b11e684:DoAnTGVL/DangBai.xaml.cs
        {
            InitializeComponent();
        }

        private void click_Huy(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
