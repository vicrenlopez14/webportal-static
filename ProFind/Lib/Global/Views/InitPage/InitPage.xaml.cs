using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Global.Views.InitPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InitPage : Page
    {
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
            new GlobalNavigationController().NavigateTo(typeof(Clients_Login));
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Clients_Register));
        }

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Admins_Login));
        }

        private void Button_Click_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Professionals_Login));
        }

        private void Hyperlink_Click(Windows.UI.Xaml.Documents.Hyperlink sender,
            Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            new GlobalNavigationController().NavigateTo(typeof(Clients_Login));
        }

        private void Button_Click_4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(AdminNS.Views.InitPage.InitPage));
        }

        private void Professionals_Login_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ClientNS.Views.InitPage.InitPage));

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
        }
    }
}