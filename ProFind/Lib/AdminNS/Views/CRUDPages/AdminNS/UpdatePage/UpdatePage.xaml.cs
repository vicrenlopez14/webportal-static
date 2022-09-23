using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
using Admin = ProFind.Lib.Global.Services.Admin;
using ProFind.Lib.Global.Helpers;
using Windows.UI.Xaml.Navigation;

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
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e.Parameter != null)
            {
                toManipulate = e.Parameter as Admin;
                loadUsefulthings();
            }
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
            Phone_tbx.Text = toManipulate.TelA;
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {


        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {

            

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

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var file = await PickFileHelper.PickImage();

                if (file != null)
                {
                    toManipulate.PictureA = await file.ToBase64StringAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void Update_btn_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName1_tbx.Text))
            {

                var dialog = new MessageDialog("The Name is empty.");
                await dialog.ShowAsync();
                return;
            }
            else if (!FieldsChecker.CheckEmail(Email_tbx.Text))
            {
                var dialog = new MessageDialog("The email is invalid.");
                await dialog.ShowAsync();
                return;
            }
            else if ( Password_tbx.Password.Length>0 && !FieldsChecker.CheckPassword(Password_tbx.Password))
            {
                var dialog = new MessageDialog("The password is invalid.");
                await dialog.ShowAsync();
                return;
            }
            try
            {
                toManipulate.EmailA = Email_tbx.Text;
                toManipulate.NameA = FirstName1_tbx.Text;
                if(Password_tbx.Password.Length > 0) toManipulate.PasswordA = Password_tbx.Password;
                toManipulate.TelA = Phone_tbx.Text;
                await APIConnection.GetConnection.PutAdminAsync(toManipulate.IdA, toManipulate);
                var dialog = new MessageDialog("Admin updated successfully.");
                await dialog.ShowAsync();
            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 204)
                {
                    var dialog = new MessageDialog("Admin updated successfully.");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("There was an error try again later.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                new InAppNavigationController().NavigateTo(typeof(ListPage.ListPageAdmin));
            }
        }

        private async void Delete_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                await APIConnection.GetConnection.DeleteAdminAsync(toManipulate.IdA);

                var dialog = new MessageDialog("Admin deleted successfully.");
                await dialog.ShowAsync();
            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 204)
                {
                    var dialog = new MessageDialog("Admin deleted successfully.");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("You have to select an admin.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                new InAppNavigationController().NavigateTo(typeof(ListPage.ListPageAdmin));
            }

        }

        private void Reset_btn_Click_1(object sender, RoutedEventArgs e)
        {

            FirstName1_tbx.Text = "";
            Email_tbx.Text = "";
            Phone_tbx.Text = "";
            Password_tbx.Password = "";
        }

        private void Back_btn_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ListPage.ListPageAdmin));
        }
    }
}



