using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
using Admin = ProFind.Lib.Global.Services.Admin;
using ProFind.Lib.Global.Helpers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.AdminNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {

        Admin toManipulate = new Admin();


        public UpdatePage()
        {
            this.InitializeComponent();
            loadUsefulthings();
        }
        private void AddEvents()
        {
            FirstName1_tbx.OnEnterNextField();
            Email_tbx.OnEnterNextField();
            Phone_tbx.OnEnterNextField();
           


        }

        private async void loadUsefulthings()
        {
            FirstName1_tbx.Text = toManipulate.NameA;
            Email_tbx.Text = toManipulate.EmailA;
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.GetAdminAsync("toManipulate");

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

            await APIConnection.GetConnection.DeleteAdminAsync(toManipulate.IdA);


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
            else if (string.IsNullOrEmpty(Phone_tbx.Text))
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




        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FirstName1_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;

        }

        private void Email_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.CheckEmail(Email_tbx.Text)) e.Handled = true;
            else e.Handled = false;

        }
    }
}



