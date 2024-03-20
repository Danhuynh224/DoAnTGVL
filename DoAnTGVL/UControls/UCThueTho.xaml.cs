using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        BUSThueTho bUSThueTho = new BUSThueTho();
        DAOTho dAOTho = new DAOTho();
        List<Tho> DStho;
        public UCThueTho()
        {
            InitializeComponent();
            DStho = dAOTho.ReadAllTho();
            bUSThueTho.CreateWrapThueTho(DStho, this);
        }

        private void click_DangBai(object sender, RoutedEventArgs e)
        {
            Window dangbai = new DangBai();
            dangbai.ShowDialog();
        }

        private void cbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cboKhuVuc.SelectedItem as ComboBoxItem != null)
                {
                    string selectedItem = (cboKhuVuc.SelectedItem as ComboBoxItem).Content.ToString();
                    DStho = dAOTho.FilterTho("KhuVuc", selectedItem);
                    bUSThueTho.CreateWrapThueTho(DStho, this);
                }
                else
                {
                    DStho = dAOTho.ReadAllTho();
                    bUSThueTho.CreateWrapThueTho(DStho, this);
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
