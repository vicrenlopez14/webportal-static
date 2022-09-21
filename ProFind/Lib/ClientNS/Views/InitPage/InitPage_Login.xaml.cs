using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.ClientNS.Views.Main_Page;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Services;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.ProfessionalNS.Views.Main_Page;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.InitPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InitPage_Login : Page
    {
        Admin id; 
        public InitPage_Login()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = new AdminLogin{Email = Email_tb.Text, Password = Password_tb.Password};
            
            try
            {
                await APIConnection.GetConnection.LoginAdminAsync(result);
            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 201)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Main_Page_Client));
                }
                else if (ex.StatusCode == 400)
                {
                    var dialog = new MessageDialog("Incorrect, check your credentials.");
                    await dialog.ShowAsync();
                }
                else
                {
                    {
                        var dialog = new MessageDialog("Something went wrong, try again later.");
                        await dialog.ShowAsync();
                    }
                }

                Console.WriteLine(ex.Message);
            }


        
          

            
            
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(InitPage));

        }

        private void Professionals_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(InitPage));

        }

        private void Hyperlink_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            new GlobalNavigationController().NavigateTo(typeof(InitPage));

        }

        private void Administrators_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.Int_Page.Int_Page));

        }

        private void Professionals_Login_Click_1(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));

        }
    }
}
