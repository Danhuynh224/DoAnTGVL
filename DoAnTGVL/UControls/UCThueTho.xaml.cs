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
    /// Interaction logic for UCThueTho.xaml
    /// </summary>
    public partial class UCThueTho : UserControl
    {
        int uc = 0;
        public UCThueTho()
        {

            InitializeComponent();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl();





        }

        private void click_DangBai(object sender, RoutedEventArgs e)
        {
            Window dangbai = new DangBai();
            dangbai.ShowDialog();
        }
        private void AddUserControl()
        {
            uc++;
           
            UCDanhSachTho userControl = new UCDanhSachTho();
            userControl.Width =280;
            userControl.Height = 450;
            
            // Thêm UserControl vào WrapPanel
            WpanelDanhS.Children.Add(userControl);
        }


    }
}
