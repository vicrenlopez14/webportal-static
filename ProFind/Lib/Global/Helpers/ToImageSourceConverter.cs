using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using System.Threading.Tasks;
using Nito.AsyncEx;
using Nito.AsyncEx.Synchronous;


namespace ProFind.Lib.Global.Helpers
{
    public class ToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is string base64String)) return null;

            try
            {
                var task = Task.Run(async () => await base64String.FromBase64String());
                return task.WaitAndUnwrapException<ImageSource>();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}