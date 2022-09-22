using ProFind.Lib.Global.Controllers;
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
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProposalNS.Accept_or_Deny
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class AcceptOrDeny : Page
    {
        private byte[] imageBytes;
        Professional Id;
        Proposal Denegada;
        public AcceptOrDeny()
        {
            this.InitializeComponent();
            Cargar();
        }
        private void AddEvents()
        {
            Title_tb.OnEnterNextField();
            Description_tb.OnEnterNextField();
            TotalPrice_tb.OnEnterNextField();

        }

        private async void Cargar()
        {
                     
            

        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               

                var file = await PickFileHelper.PickImage();

                if (file != null)
                {
                  imageBytes  = await file.ToByteArrayAsync();
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

        private void TotalPrice_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyFloats(e,TotalPrice_tb.Text)) e.Handled = true;
            else e.Handled = false;
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            var LoggendPro = LoggedProfessionalStore.LoggedProfessional;
            var toCreateClien = new Project { IdPj = "", TitlePj = Title_tb.Text, DescriptionPj = Description_tb.Text, PicturePj = imageBytes, TotalPricePj = int.Parse(TotalPrice_tb.Text), IdP1 = LoggendPro.IdP  };


            var result = await APIConnection.GetConnection.PostProjectAsync(toCreateClien);

            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ProjectNS.ReadPage.ReadPage));



        }


        private async void Decline_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteProposalAsync(Denegada.IdPp);
        }
    }
}
