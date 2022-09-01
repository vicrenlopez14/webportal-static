using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Client_Update_Delete : Page
    {
        Client toManipulate = new Client();

        public Client_Update_Delete()
        {
            this.InitializeComponent();
        }
        private async void loadUsefulthings()
        {
            Name1_tbx.Text = toManipulate.NameC;
            Email_tbx.Text = toManipulate.EmailC;
            
            Picture_img.Source = toManipulate.PictureC.ToBitmapImage();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            toManipulate = (Client)e.Parameter;
            loadUsefulthings();
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            toManipulate = new Client()
            {
                IdC = toManipulate.IdC,
            };

            loadUsefulthings();
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await new ClientService().Update(toManipulate); 

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

        private async Task Delete_btn_ClickAsync(object sender, RoutedEventArgs e)
        {
            await new ClientService().Delete(toManipulate.IdC);

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
            toManipulate.PictureC = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await new ClientService().Delete(toManipulate.IdC);

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
    }
}
