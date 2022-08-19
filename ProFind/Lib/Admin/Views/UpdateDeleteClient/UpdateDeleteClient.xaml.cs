using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Controllers;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.UpdateDeleteClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpdateDeleteClient : Page
    {

        private PFClient client;

        public UpdateDeleteClient()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            client = (PFClient)e.Parameter;

            NameC.Text = client.NameC;
            Email.Text = client.EmailC;
            passwordBox.Text = client.PasswordC;
        }

        private async void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            byte[] trash = new byte[5];
            PFClient updatedClient = new PFClient (client.IdC,NameC.Text,Email.Text,passwordBox.Text,trash);

            var result = await new PfClientService().Update(updatedClient);

            if(result == System.Net.HttpStatusCode.OK)
            {
                new GlobalNavigationController().GoBack();
            }
            if (string.IsNullOrEmpty(NameC.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Email.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(passwordBox.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string IdToDelete = client.IdC;

            var result = await new PfClientService().Delete(IdToDelete);

            new GlobalNavigationController().GoBack();  
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            new Controllers.InAppNavigationController().GoBack();
        }

        private void btnExaminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
