using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Client = ProFind.Lib.Global.Services.Client;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Create_page : Page
    {
       
        private byte[] imageBytes;
        public Create_page()
        {
            this.InitializeComponent();
            AddEvents();
        }
        private void AddEvents()
        {
            Name_tb.OnEnterNextField();
            Email_tb.OnEnterNextField();
            PhoneNumber_tb.OnEnterNextField();
           


        }



        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

               

                var ToCreateAdmin = new Client("", Name_tb.Text, Email_tb.Text, Password_pb.Password, imageBytes); 
               

                var result = await APIConnection.GetConnection.PostClientAsync(ToCreateAdmin);

                ToggleThemeTeachingTip2.IsOpen = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
        }

        private void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
        }

        private void Name_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void Email_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.CheckEmail(Email_tb.Text)) e.Handled = true;
            else e.Handled = false;
        }
    }
}
