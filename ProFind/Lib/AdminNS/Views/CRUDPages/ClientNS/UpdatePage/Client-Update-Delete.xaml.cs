using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Client = ProFind.Lib.Global.Services.Client;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Client_Update_Delete : Page
    {


        Client toManipulateClient;

        public Client_Update_Delete()
        {
            this.InitializeComponent();
            AddEvents();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter == null)
            {
                new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage.Clients_List));
            }
            else
            {
                {
                    toManipulateClient = e.Parameter as Client;
                    FillFields();
                }
            }
        }

        private void FillFields()
        {

        }

        private void AddEvents()
        {
            Name1_tbx.OnEnterNextField();
            Email_tbx.OnEnterNextField();


        }


        private async Task Delete_btn_ClickAsync(object sender, RoutedEventArgs e)
        {

            await APIConnection.GetConnection.DeleteClientAsync(toManipulateClient.IdC);

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

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteClientAsync(toManipulateClient.IdC);

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
            if (FieldsChecker.OnlyLetters(e))
            {
                e.Handled = true;
                toManipulateClient.NameC = Name1_tbx.Text;
            }
            
            else e.Handled = false;
        }

        private void Email_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.CheckEmail(Email_tbx.Text))
            {
                e.Handled = true;
                toManipulateClient.EmailC = Email_tbx.Text;
            }
            else e.Handled = false;
        }

        private void Phone_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
        }

        private async void Update_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                await APIConnection.GetConnection.PutClientAsync(toManipulateClient.IdC, toManipulateClient);

                // Message dialog indicating success
                var dialog = new MessageDialog("The client has been updated");
                await dialog.ShowAsync();

            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 200 || ex.StatusCode == 201)
                {
                    // Message dialog indicating success
                    var dialog = new MessageDialog("The client has been updated");
                    await dialog.ShowAsync();

                }
                else
                {
                    // Message dialog indicating error
                    var dialog = new MessageDialog("The client has not been updated, an error ocurred, try again later.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                // Navigate to clients list
                new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage.Clients_List));
            }
        }

        private async void Delete_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                await APIConnection.GetConnection.DeleteClientAsync(toManipulateClient.IdC);

                // Show success content dialog
                var dialog = new MessageDialog("The client has been deleted");
                await dialog.ShowAsync();

            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 200 || ex.StatusCode == 201)
                {
                    // Show success content dialog
                    var dialog = new MessageDialog("The client has been deleted");
                    await dialog.ShowAsync();
                }
                else
                {
                    // Show error content dialog
                    var dialog = new MessageDialog("The client has not been deleted, an error ocurred, try again later.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage.Clients_List));
            }
        }

        private async void UploadPicture_btn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                toManipulateClient.PictureC = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
                // Success message dialog
                var dialog = new MessageDialog("The picture has been uploaded");
                await dialog.ShowAsync();
            }
            catch
            {
                // Failure dialog
                var dialog = new MessageDialog("No picture was selected.");
                await dialog.ShowAsync();
            }
        }

        private void Back_btn_Click_1(object sender, RoutedEventArgs e)
        {

            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage.Clients_List));


        }

        private void Name1_tbx_TextChanged(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
        }

        private void Email_tbx_TextChanged(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }

       
    }
}