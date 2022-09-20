using Windows.System;
using Windows.UI.Input.Preview.Injection;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ProFind.Lib.Global.Helpers
{
    public static class TextBoxExtension
    {
        public static void OnEnterNextField(this TextBox textBox)
        {
            textBox.KeyDown += delegate(object sender, KeyRoutedEventArgs e)
            {
                if (e.Key == VirtualKey.Enter)
                {
                    var injector =  InputInjector.TryCreate();

                    if (injector != null)
                    {
                        // Press the tab key
                        
                    }
                    
                }
            };
        }
    }
}