using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using ProFind.Lib.ProfessionalNS.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
        private string imageBytes;
        Project id1;
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
                id1 = e.Parameter as Project;

            }
        }
        private void AddEvents()
        {
            Title_tb1.OnEnterNextField();
            Description_tb.OnEnterNextField();
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedImage = await PickFileHelper.PickImage();
                SelectedPicture_tbk.Text = selectedImage.Name;


                var file = await PickFileHelper.PickImage();

                if (file != null)
                {
                    SelectedPicture_tbk.Text = file.Name;
                    imageBytes = await file.ToBase64StringAsync();

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

        private void Title_tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private async void Create_btn_Click_2(object sender, RoutedEventArgs e)
        {

            if (!FieldsChecker.CheckName(Title_tb1.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
                return;
            }
            else if (!FieldsChecker.OnlyLetters(Description_tb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
                return;
            }

            try
            {


                var loggedprofesionales = LoggedProfessionalStore.LoggedProfessional;
                var toCreateActivity = new Activity { IdAc = "", TitleAc = Title_tb1.Text, DescriptionAc = Description_tb.Text, PictureAc = imageBytes, IdPj1 = id1.IdPj};

                var result = await APIConnection.GetConnection.PostActivityAsync(toCreateActivity);



            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode >= 200 && ex.StatusCode <= 205)
                {
                    var dialog = new MessageDialog("Activity was created .");
                    await dialog.ShowAsync();

                }
                else
                {
                    var dialog = new MessageDialog("There was an error creating Activity, please try again later.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.ListPage.ListPage));
            }

        }
       
    }
}
