using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.ProfessionalNS.Views.Main_Page;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ProFind.Lib.Global.Views.InitPage
{
    public sealed partial class UnidentifiedUserForm : UserControl
    {
        public UnidentifiedUserForm()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ButtonClickHomeMethod();
        }



        private void mail_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                e.Handled = true;
                ButtonClickHomeMethod();
            }
        }

        void ButtonClickHomeMethod()
        {

            var mail = Mail_tb.Text;


            switch (mail)
            {
                case "admin@profind.work":
                    new GlobalNavigationController().NavigateTo(typeof(AdminNS.Views.Main_Page_Admin.Main_Page_Admin));
                    break;
                case "professional@profind.work":
                    new GlobalNavigationController().NavigateTo(typeof(Main_Page_Professional));
                    break;
                case "client@profind.work":
                    new GlobalNavigationController().NavigateTo(typeof(ClientNS.Views.Main_Page.Main_Page_Client));
                    break;
                default:
                    new GlobalNavigationController().NavigateTo(typeof(ClientNS.Views.Main_Page.Main_Page_Client));
                    break;
            }


        }
    }


}