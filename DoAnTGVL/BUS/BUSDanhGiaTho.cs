using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DoAnTGVL.BUS
{
    class BUSDanhGiaTho
    {
        public void Add(BitmapImage image)
        {
            string directoryPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImageDanhGia");
            Directory.CreateDirectory(directoryPath);

            // Tạo một đường dẫn đầy đủ đến tệp hình ảnh
            string filePath = System.IO.Path.Combine(directoryPath, "saved_image.jpg");

            // Tạo một FileStream để ghi dữ liệu hình ảnh vào tệp
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                // Tạo một BitmapEncoder để mã hóa và lưu hình ảnh vào FileStream
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(stream);
            }
        }
    }
}
