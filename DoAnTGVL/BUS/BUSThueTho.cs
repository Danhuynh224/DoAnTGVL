using DoAnTGVL.Class;
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
        BUSDanhSachTho bUSDanhSachTho = new BUSDanhSachTho();
        UserControl userControl;
        int i = 0;
        public UCThueTho CreateUCThueTho()
        {
            List<Tho> DStho = dAOTho.ReadDatabase();
            int n = DStho.Count;
            UCThueTho uCThueTho = new UCThueTho();
            for(int i=0;i<n;i++)
            {
                userControl= bUSDanhSachTho.CreateDSTho(DStho[i]);
                
                userControl.Width = 280;
                userControl.Height = 450;
                userControl.Margin = new Thickness(10);
                // Thêm UserControl vào WrapPanel
                uCThueTho.WpanelDanhS.Children.Add(userControl);
            }    
            return uCThueTho;

        }
    }
}
