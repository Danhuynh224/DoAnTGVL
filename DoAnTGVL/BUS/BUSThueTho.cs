﻿using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace DoAnTGVL.BUS
{

    public class BUSThueTho
    {
        DAOTho dAOTho = new DAOTho();
        UserControl userControl;
        public void CreateWrapThueTho(List<Tho> DStho, UCThueTho uCThueTho)
        {
            uCThueTho.WpanelDanhS.Children.Clear();
            foreach (Tho tho in DStho)
            {
                userControl = new UCDanhSachTho(tho);
                userControl.Width = 280;
                userControl.Height = 450;
                userControl.Margin = new Thickness(10);
                // Thêm UserControl vào WrapPanel
                uCThueTho.WpanelDanhS.Children.Add(userControl);
            }
        }
    }   
}
