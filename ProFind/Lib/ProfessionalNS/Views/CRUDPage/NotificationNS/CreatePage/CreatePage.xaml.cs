using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
        private byte[] imageBytes;
        Project id1;
        Client id2;
        private Client ranks2;
        private Project ranks = new Project();
        Notification toManipulate = new Notification();
        Professional id; 

        public CreatePage()
        {
            this.InitializeComponent();
            
            AddEvents();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
               id2 = e.Parameter as Client;
               
            }
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrEmpty(Title_tb1.Text))
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



                var toCreateClien = new Notification { IdN = "", TitleN = Title_tb1.Text, DescriptionN = Description_tb.Text, PictureN = imageBytes, IdC3 = id2.IdC, DateTimeIssuedN = (DateTimeOffset)DateTimeOffset.Now };

                var result = await APIConnection.GetConnection.PostNotificationAsync(toCreateClien);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               
            }

        }

        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            
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

        private async void Create_btn_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Title_tb1.Text))
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

                

                var toCreateClien = new Notification { IdN = "", TitleN = Title_tb1.Text, DescriptionN = Description_tb.Text, PictureN = imageBytes, IdC3 = id2.IdC, DateTimeIssuedN = (DateTimeOffset)DateTimeOffset.Now  };

                var result = await APIConnection.GetConnection.PostNotificationAsync(toCreateClien);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        private void Title_tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private async void PictureSelection_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {


                var file = await PickFileHelper.PickImage();

                if (file != null)
                {
                    SelectedPicture_tbk.Text = file.Name;
                    imageBytes = await file.ToByteArrayAsync();

                    //SelectedPicture_pp.ProfilePicture = imageBytes.ToBitmapImage();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                PictureSelection_btn.IsChecked = false;
            }
        }

        private void Title_tb1_KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void Description_tb_KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void AddEvents()
        {
            Title_tb1.OnEnterNextField();
            Description_tb.OnEnterNextField();
        }
    }
}
