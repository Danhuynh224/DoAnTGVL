using DoAnTGVL.BUS;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for DanhGiaTho.xaml
    /// </summary>
    public partial class DanhGiaTho : Window
    {
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();  
        public DanhGiaTho()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {       
            Image clickedImage = sender as Image;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage btmap = new BitmapImage(new Uri(openFileDialog.FileName));
                clickedImage.Source = btmap;
                clickedImage.Height = 88;
                
                string source = openFileDialog.FileName;
                FileInfo info = new FileInfo(source);

                string path = System.IO.Path.GetFullPath("ImageDanhGia/");
                string folder_path = path.Substring(0, path.IndexOf("bin"));

                string destination = folder_path+ @"ImageDanhGia\" +System.IO.Path.GetFileName(source);
                info.CopyTo(destination);
            }
        }

        private void ComfirmClick_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
