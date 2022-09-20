using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Views;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.ClientNS.Views.InitPage;
using ProFind.Lib.Global.Services;

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


        private void Administrators_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.Int_Page.Int_Page));
        }

        private void Clients_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.InitPage.InitPage));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = new Professional { EmailP = Email_tb.Text, PasswordP = Password_tb.Password };
            await APIConnection.GetConnection.LoginProfessionalAsync(result);


            new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.Main_Page.Main_Page_Professional));


            FailedAuth_tt.IsOpen = true;


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

        private void Email_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_tb_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
