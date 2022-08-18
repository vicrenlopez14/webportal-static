using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
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

namespace ProFind.Lib.Admin.Views.Client_List
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Clients_List : Page
    {
        public Clients_List()
        {
            this.InitializeComponent();
            GetClientList();
        }

        public async void GetClientList()
        {
            var ClientService = new PfClientService();
            List<PFClient> ClientList = new List<PFClient>();

            ClientList = await ClientService.ListObjectAsync() as List<PFClient>;

            ClientListView.ItemsSource = ClientList;    

        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFClient clickedItem = e.ClickedItem as PFClient;

            new AdminNavigationController().NavigateTo(typeof(
                Lib.Admin.Views.UpdateDeleteClient.UpdateDeleteClient), clickedItem);
        }
    }
}
