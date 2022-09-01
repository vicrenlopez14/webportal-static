using ProFind.Lib.Global.Controllers;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.InitPage
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

        }

        private void Professionals_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProfessionalNS.Views.InitPage.InitPage));
        }

        private void Admins_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ClientNS.Views.InitPage.InitPage_Login));
        }

        private async Task Button_Click_5Async(object sender, RoutedEventArgs e)
        {
            var result = await new AdminService().Login(Email_tb.Text, Password_tb.Password);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.Main_Page_Admin.Main_Page_Admin));
            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var result = await new AdminService().Login(Email_tb.Text, Password_tb.Password);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.Main_Page_Admin.Main_Page_Admin));
            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }
        }
    }
}
