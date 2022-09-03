using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using ProFind.Lib.Global.Services.Models;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Create_Client : Page
    {

        Client toManipulate = new Client();
   
        public Create_Client()
        {
            this.InitializeComponent();
        }

        private async Task Create_btn_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                Creation_pr.IsActive = true;
                byte[] da = toManipulate.PictureC = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

                var toCreateClien = new Client(Name_tb.Text, Email_tb.Text, Password_pb.Password, "", da);
               

                var result = await APIConnection.GetConnection.PostClientAsync(toCreateClien);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Creation_pr.IsActive = false;
            }

        }
        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
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
            try
            {
                Creation_pr.IsActive = true;
                byte[] da = toManipulate.PictureC = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

                var toCreateClien = new Client(Name_tb.Text, Email_tb.Text, Password_pb.Password, "", da);


                var result = await APIConnection.GetConnection.PostClientAsync(toCreateClien);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Creation_pr.IsActive = false;
            }
        }

        private void PhoneNumber_tb_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
        {

        }
    }

}
