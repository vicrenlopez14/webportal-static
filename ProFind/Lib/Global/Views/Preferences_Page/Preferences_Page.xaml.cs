using ProFind.Lib.Global.Helpers;
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

<<<<<<< HEAD
           
=======
>>>>>>> 3dff7887ad5586e81c1d06a2fe0aeba7ee47f2ef
        }

        private void OnThemeRadioButtonKeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void OnThemeRadioButtonChecked(object sender, RoutedEventArgs e)
        {

        }

        private void DarkModeToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (DarkModeToggleSwitch.IsOn)
            {
                ApplicationData.Current.LocalSettings.Values["DarkMode"] = true;
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values["DarkMode"] = false;
            }
        }

        private void SoundEffectsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (SoundEffectsToggleSwitch.IsOn)
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.On;
            }
            else
            {
                {
                    ElementSoundPlayer.State = ElementSoundPlayerState.Off;
                }
            }
        }
    }
}
