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

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ActivityNs.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        Activity toManipulateTag;
        private string imageBytes;
        public UpdatePage()
        {
            this.InitializeComponent();
          
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                toManipulateTag = (Activity)e.Parameter;
                FillFields();
            }
            else
            {
                // Go back to professionals list
                // Error message dialog
                var dialog = new MessageDialog("Activity not found or  not valid.");
                await dialog.ShowAsync();

                // Back to profesionals list
                new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ActivityNs.ListaPage.ListPage));
            }
        }
        private void FillFields()
        {
            Title_tb1.Text = toManipulateTag.TitleAc;
            Description_tb.Text = toManipulateTag.DescriptionAc;


        }
        private void Title_tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged_1(object sender, TextChangedEventArgs e)
        {

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
                var toUpdateActivity = new Activity { IdAc = toManipulateTag.IdAc, TitleAc = Title_tb1.Text, DescriptionAc = Description_tb.Text, PictureAc = imageBytes, IdPj1 = toManipulateTag.IdPj1 };

                await APIConnection.GetConnection.PutActivityAsync(toManipulateTag.IdAc, toUpdateActivity);


            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 200 || ex.StatusCode == 201 || ex.StatusCode == 204)
                {
                    var dialog = new MessageDialog("The Activity has been updated.");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("There was an error update the Activity, try again later.");
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
