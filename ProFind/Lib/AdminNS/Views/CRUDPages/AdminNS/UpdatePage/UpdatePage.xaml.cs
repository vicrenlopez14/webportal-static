using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services.Models;
using ProFind.Lib.Global.Services;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.AdminNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {


        private byte[] imageBytes;
        Admin id = new Admin();

        public UpdatePage()
        {
            this.InitializeComponent();


        }




        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {

        }


        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {



            byte[] da = id.PictureA = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

            var toUpdapteAdmin = new Admin("", FirstName1_tbx.Text, Email_tbx.Text, Telefono_tbx.Text, Password_tbx.Password, da);

            await APIConnection.GetConnection.PutAdminAsync(id.IdA, toUpdapteAdmin);



            
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

            await APIConnection.GetConnection.DeleteAdminAsync(id.IdA);


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




        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}



