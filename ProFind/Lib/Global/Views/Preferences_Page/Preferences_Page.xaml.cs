using System;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Global.Views.Preferences_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Preferences_Page : Page
    {
        public Preferences_Page()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Load the settings
            LoadSettings();
        }

        private void LoadSettings()
        {
            int selectedIndex = 2;
            
            var applicationTheme = App.Current.RequestedTheme;
            if (applicationTheme == ApplicationTheme.Dark)
            {
                selectedIndex = 1;
            }
            else if (applicationTheme == ApplicationTheme.Light)
            {
                selectedIndex = 0;
            }
            else
            {
                selectedIndex = 2;
            }

           
        }

        private void OnThemeRadioButtonKeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void OnThemeRadioButtonChecked(object sender, RoutedEventArgs e)
        {

        }

        private void ThemeMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void SoundMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
