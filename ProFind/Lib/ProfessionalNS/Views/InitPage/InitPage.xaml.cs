using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Views;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.ClientNS.Views.InitPage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.InitPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InitPage : Page
    {
        public InitPage()
        {
            this.InitializeComponent();
        }

        private void RichTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Clients_Login));

        }

        private void Button_Click_4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ClientNS.Views.InitPage.InitPage));
        }

        private void Professionals_Login_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(InitPage_Login));

        }

        private async void Button_Click_5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var result = await new ProfessionalService().Login(Email_tb.Text, Password_tb.Password);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.Main_Page.Main_Page_Professional));
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
    }
}
