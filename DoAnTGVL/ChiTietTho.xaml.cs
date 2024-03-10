﻿using DoAnTGVL.UControls;
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
    /// Interaction logic for ChiTietTho.xaml
    /// </summary>
    public partial class ChiTietTho : Window
    {
        public ChiTietTho()
        {
            InitializeComponent();
            AddUserControl();
            AddUserControl();
            AddUserControl();
            AddUserControl(); AddUserControl();
        }
        private void AddUserControl()
        {

            UCDanhGia userControl = new UCDanhGia();
            userControl.Width = 500;
            userControl.Height = 200;

            // Thêm UserControl vào WrapPanel
           WpanelDanhGia.Children.Add(userControl);
        }
    }
}