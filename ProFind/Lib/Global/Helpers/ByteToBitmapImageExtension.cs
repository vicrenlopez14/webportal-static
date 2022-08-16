using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace ProFind.Lib.Global.Helpers
{
    public static class ByteToBitmapImage
    {
        public static BitmapImage ToBitmapImage(this byte[] bytes)
        {
            BitmapImage image = new BitmapImage();
            using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                stream.AsStreamForWrite().Write(bytes, 0, bytes.Length);
                image.SetSource(stream);
            }
            return image;
        }
    }
}
