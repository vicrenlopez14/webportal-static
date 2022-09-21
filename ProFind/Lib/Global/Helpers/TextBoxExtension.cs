using Windows.System;
using Windows.UI.Input.Preview.Injection;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Microsoft.UI.Xaml.Controls;

namespace ProFind.Lib.Global.Helpers
{
    public static class TextBoxExtension
    {
        public static void OnEnterNextField(this TextBox textBox)
        {
            textBox.KeyDown += delegate(object sender, KeyRoutedEventArgs e)
            {
                if (e.Key == VirtualKey.Enter)
                    PressTabKey();
            };
        }
        
        public static void OnEnterNextField(this NumberBox numberBox)
        {
            numberBox.KeyDown += delegate(object sender, KeyRoutedEventArgs e)
            {
                if (e.Key == VirtualKey.Enter)
                    PressTabKey();
            };
        }
        
        public static void OnEnterNextField(this PasswordBox passwordBox)
        {
            passwordBox.KeyDown += delegate(object sender, KeyRoutedEventArgs e)
            {
                if (e.Key == VirtualKey.Enter)
                    PressTabKey();
            };
        }


        private static void PressTabKey()
        {
            var injector = InputInjector.TryCreate();

            if (injector != null)
            {
                // Press the tab key
                var info = new InjectedInputKeyboardInfo();
                info.VirtualKey = (ushort)(VirtualKey.Tab);
                injector.InjectKeyboardInput(new[] { info });
            }
        }
    }
}