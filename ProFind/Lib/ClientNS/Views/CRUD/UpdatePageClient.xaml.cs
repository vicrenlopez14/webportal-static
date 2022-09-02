using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpdatePageClient : Page
    {

      

        public UpdatePageClient()
        {
            this.InitializeComponent();
        }

        

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName1_tbx.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Email_tbx.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Password_tbx.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }

          
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
        }

        private async void Back_btn_Click(object sender, RoutedEventArgs e)
        {   
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void FirstName1_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Email_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
        }
        
    }
}
