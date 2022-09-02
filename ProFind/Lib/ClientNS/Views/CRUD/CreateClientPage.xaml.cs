using MySql.Data.MySqlClient.Memcached;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateClientPage : Page
    {
        public CreateClientPage()
        {
            this.InitializeComponent();
        }

        private void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Name_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Email_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Password_pb_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
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
            else if (string.IsNullOrEmpty(Password_pb.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }


            
        }
    }
}
