using DoAnTGVL.Class;
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
    class BUSTimViec
    {
        UserControl userControl;
        public void CreateWrapBaiDang(List<BaiDang> DSbaidang, UCTimViec uctimviec)
        {
            uctimviec.WpanelDanhS.Children.Clear();
            foreach (BaiDang baidang in DSbaidang)
            {
                userControl = new UCDanhSachCongViec(baidang);
                userControl.Width = 620;
                userControl.Height = 370;
                userControl.Margin = new Thickness(10);
                // Thêm UserControl vào WrapPanel
                uctimviec.WpanelDanhS.Children.Add(userControl);
            }
        }
    }
}
