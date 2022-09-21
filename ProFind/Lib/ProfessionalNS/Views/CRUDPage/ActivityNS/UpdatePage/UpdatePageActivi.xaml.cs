using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePageActivi : Page
    {
        private byte[] imageBytes;
        Professional id2;
        private bool isFirstAdmin = false;
        Project id = new Project();
        Activity id33;
        public UpdatePageActivi()
        {
            this.InitializeComponent();
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
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

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                var toCreateAdmin = new Activity {  TitleA = Title_tb.Text, DescriptionA = Description_tb.Text, ExpectedBeginA = ExpectedBegin_dp.Date, ExpectedEndA = ExpectedEnd_dp.Date, PictureA = imageBytes };


                 await APIConnection.GetConnection.PutActivityAsync( id33.IdA,toCreateAdmin);

                new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.ListPage.LisPageActivi));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        private void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            Title_tb.Text = "";
            Description_tb.Text = ""; 
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteActivityAsync( id33.IdA);
        }

        private void Title_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void Description_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void AddEvents()
        {
            Title_tb.OnEnterNextField();
            Description_tb.OnEnterNextField();
        }
    }
}
