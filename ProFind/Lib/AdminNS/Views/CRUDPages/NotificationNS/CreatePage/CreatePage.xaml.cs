using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services.Models;
using ProFind.Lib.Global.Services;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
    
        private byte[] imageBytes;


        public CreatePage()
        {
            this.InitializeComponent();
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Title_tb.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
                return;
            }
            else if (string.IsNullOrEmpty(Description_tb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
                return;
            }


            try
            {
                Creation_pr.IsActive = true;

                var toCreateClien = new Notification("", Title_tb.Text, Description_tb.Text, Caledar.DateFormat, imageBytes, "" );


                var result = await APIConnection.GetConnection.PostNotificationAsync(toCreateClien);



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

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }
    }
}
