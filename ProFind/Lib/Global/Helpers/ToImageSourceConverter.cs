using System;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Nito.AsyncEx;

namespace ProFind.Lib.Global.Helpers
{
    //public class ToImageSourceConverter : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, string language)
    //    {
    //        //// Verify target type is ImageSource
    //        //if (targetType != typeof(ImageSource))
    //        //    return null;
            
    //        //// read stream
    //        //var bytes = Convert.FromBase64String(base64);
    //        //var image = bytes.AsBuffer().AsStream().AsRandomAccessStream();
    //        //// decode image sync
    //        //var task = BitmapDecoder.CreateAsync(image);
    //        //var decoder = AsyncContext.Run(BitmapDecoder.CreateAsync);
            
    //        //// var decoder = await BitmapDecoder.CreateAsync(image);
    //        //// // BitmapDecoder create sync
    //        //// var bitmap = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);
    //        ////
    //        //image.Seek(0);

    //        //var output = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);
    //        //output.SetSource(image);
    //        //return output;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, string language)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}