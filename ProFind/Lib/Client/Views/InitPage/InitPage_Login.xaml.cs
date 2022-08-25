using ProFind.Lib.Global.Controllers;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.InitPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InitPage_Login : Page
    {
        public InitPage_Login()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = await new PfClientService().Login(Email_tb.Text, Password_tb.Password);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.Client.Views.Main_Page.Main_Page_Client));

            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }

            if (string.IsNullOrEmpty(Email_tb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Password_tb.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Admin.Views.InitPage.InitPage));

        }

        private void Professionals_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Professional.Views.InitPage.InitPage));

        }

        private void Hyperlink_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.Client.Views.InitPage.InitPage));

        }
    }
}
