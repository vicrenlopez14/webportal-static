using UWP_ProFind.Lib.Admin.Views.Main_Page_Admin;
using UWP_ProFind.Lib.Global.Controllers;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_ProFind.Lib.Global.Views.InitPage
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
    }
}
