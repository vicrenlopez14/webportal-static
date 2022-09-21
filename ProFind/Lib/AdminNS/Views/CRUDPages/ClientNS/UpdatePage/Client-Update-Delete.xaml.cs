using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Client = ProFind.Lib.Global.Services.Client;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Client_Update_Delete : Page
    {


        Client id;

        public Client_Update_Delete()
        {
            this.InitializeComponent();
            AddEvents();
        }
        private void AddEvents()
        {
            Name1_tbx.OnEnterNextField();
            Email_tbx.OnEnterNextField();
           Phone_tbx.OnEnterNextField();



        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            byte[] da = id.PictureC = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

            var toUpdapteClient = new Client("", Name1_tbx.Text, Email_tbx.Text, Password_tbx.Password, da);

            await APIConnection.GetConnection.PutClientAsync(id.IdC, toUpdapteClient);

        }

        private async Task Delete_btn_ClickAsync(object sender, RoutedEventArgs e)
        {

            await APIConnection.GetConnection.DeleteClientAsync(id.IdC);

            if (string.IsNullOrEmpty(Name1_tbx.Text))
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

        private async void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteClientAsync(id.IdC);

            if (string.IsNullOrEmpty(Name1_tbx.Text))
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

        private void Name1_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
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
