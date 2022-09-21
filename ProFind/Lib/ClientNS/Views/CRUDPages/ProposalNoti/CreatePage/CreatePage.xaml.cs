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

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ProposalNoti.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
        private byte[] imageBytes;
        Professional Id;

        public CreatePage()
        {
            this.InitializeComponent();
            loadUsefulThings();
        }
        public async void loadUsefulThings()
        {
           var Id2 = await APIConnection.GetConnection.GetProfessionalAsync(Id.IdP);

            Rank_cb.ItemsSource = Id2;
        
        }
        private void Action_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void content_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
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

        private async void Send_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                var ToCreateAdmin = new Proposalnotification { IdPn = "", ContentPn = content.Text, ActionPn = Action.Text, };


                //var result = await APIConnection.GetConnection.PostPropo(ToCreateAdmin);


            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 201)
                {
                   

                }
            }
            finally
            {
               
            }
        }
    }
}
