﻿using DoAnTGVL.BUS;
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
        FilterTho filterTho = new FilterTho();
        List<Tho> DStho;
        public UCThueTho()
        {
            InitializeComponent();
            this.DataContext = filterTho;
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
            filterTho.KhuVuc = (cboKhuVuc.SelectedItem != null) ? (cboKhuVuc.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterTho.KinhNghiem = (cboKinhNghiem.SelectedItem != null) ? (cboKinhNghiem.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterTho.DanhGia = (cboDanhGia.SelectedItem != null) ? float.Parse((cboDanhGia.SelectedItem as ComboBoxItem).Content.ToString()) : 0;
            DStho = dAOTho.FilterTho(filterTho);
            bUSThueTho.CreateWrapThueTho(DStho, this);
        }
    }
}
