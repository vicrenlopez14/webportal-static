using System.IO;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace ProFind.Lib.Global.Helpers
{
    public static class ByteToBitmapImage
    {
        public static BitmapImage ToBitmapImage(this byte[] bytes)
        {
            if (bytes == null)
                return null;
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
