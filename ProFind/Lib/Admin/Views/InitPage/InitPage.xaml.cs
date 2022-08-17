using Application.Services;
using ProFind.Lib.Global.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.InitPage
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
            new GlobalNavigationController().NavigateTo(typeof(Professional.Views.InitPage.InitPage));
        }

        private void Admins_Login_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Client.Views.InitPage.InitPage_Login));
        }

        private async Task Button_Click_5Async(object sender, RoutedEventArgs e)
        {
            var result = await new PFAdminService().Login(Email_tb.Text, Password_tb.Password);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.Admin.Views.Main_Page_Admin.Main_Page_Admin));
            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var result = await new PFAdminService().Login(Email_tb.Text, Password_tb.Password);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().NavigateTo(typeof(Lib.Admin.Views.Main_Page_Admin.Main_Page_Admin));
            }
            else
            {
                FailedAuth_tt.IsOpen = true;
            }
        }
    }
}
