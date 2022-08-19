using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;
using Application.Services;
using System.Threading.Tasks;
using Application.Models;
using ProFind.Lib.Global.Helpers;
using Windows.UI.Popups;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.InitPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InitPage : Page
    {
        byte[] pictureBytes;
        public InitPage()
        {
            WebAPIConnection.Run();

            this.InitializeComponent();
        }

        private void UnidentifiedUserForm_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void Trigger_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void Button_Click_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void Hyperlink_Click(Windows.UI.Xaml.Documents.Hyperlink sender,
            Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            new GlobalNavigationController().NavigateTo(typeof(InitPage_Login));

        }

        private void Button_Click_4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Admin.Views.InitPage.InitPage));
        }

        private void Professionals_Login_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Professional.Views.InitPage.InitPage));

        }

        private async Task Button_Click_5Async(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var registerClient = new RegisterClient(Name_tb.Text, Email_tb.Text, Password_tb.Password, pictureBytes);
            var result = await new PfClientService().Register(registerClient);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.Main_Page.Main_Page_Professional));
            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }
        }

        private void Name_tb_TextChanged(TextBlock sender, TextChangedEventArgs e)
        {
            ProfilePicture_pp.DisplayName = sender.Text;
        }

        private async void btnExaminar_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            pictureBytes = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private void Name_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void Button_Click_5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var registerClient = new RegisterClient(Name_tb.Text, Email_tb.Text, Password_tb.Password, pictureBytes);
            var result = await new PfClientService().Register(registerClient);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.Client.Views.Main_Page.Main_Page_Client));
            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }

            if (string.IsNullOrEmpty(Name_tb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Email_tb.Text))
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