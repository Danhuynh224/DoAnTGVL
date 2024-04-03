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
using EnvDTE;
using System.Runtime.InteropServices;



namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for DanhGiaTho.xaml
    /// </summary>
    public partial class DanhGiaTho : System.Windows.Window
    {
<<<<<<< HEAD
        //BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
=======
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();  
>>>>>>> dcdd0e647d99d26e9c401c009a5a7ab8037656e2
        public DanhGiaTho()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
<<<<<<< HEAD
        {

            Image clickedImage = sender as Image;

            string imagePath = "C:/Users/ADMIN"; // Đường dẫn tương đối đến ảnh
            Uri imageUri = new Uri(imagePath, UriKind.Relative);

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = imageUri;
            bitmap.EndInit();
            clickedImage.Source = bitmap;
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            //openFileDialog.FilterIndex = 1;
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    BitmapImage btmap = new BitmapImage(new Uri(openFileDialog.FileName));
            //    clickedImage.Source = btmap;
            //    clickedImage.Height = 88;
            //    clickedImage.Width = 88;
            //    string source = openFileDialog.FileName;
            //    string fileName = System.IO.Path.GetFileName(source);
            //    string destinationFolder = "ImageDanhGia";
            //    string path = System.IO.Path.GetFullPath(destinationFolder);
            //    string folder_path = path.Substring(0, path.IndexOf("bin"));
            //    string destination = System.IO.Path.Combine(folder_path, destinationFolder, fileName);
            //    if (!System.IO.File.Exists(destination))
            //    {
            //        System.IO.File.Copy(source, destination);

            //    }
            //    else
            //    {
            //        string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fileName);
            //        string fileExtension = System.IO.Path.GetExtension(fileName);
            //        string newFileName = fileNameWithoutExtension + "_" + Guid.NewGuid().ToString().Substring(0, 8) + fileExtension;
            //        destination = System.IO.Path.Combine(folder_path, destinationFolder, newFileName);
            //        System.IO.File.Copy(source, destination);
            //    }
            //}
=======
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
>>>>>>> dcdd0e647d99d26e9c401c009a5a7ab8037656e2
        }

        private void ComfirmClick_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
