﻿using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Client = ProFind.Lib.Global.Services.Client;
using ProFind.Lib.Global.Controllers;
using System.Collections.Generic;
using ProFind.Lib.AdminNS.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Clients_List : Page
    {
        Client Id1;
        public Clients_List()
        {
            this.InitializeComponent();
            GetClientsList();
        }

        public async void GetClientsList()
        {
            Activities_lw.ItemsSource = await APIConnection.GetConnection.GetClientsAsync() as List<Client>;
        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Client clickedItem = e.ClickedItem as Client;


        }

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.Search_Pages.Search_Page_Clients));
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.CreatePage.Create_page));
        }

        private void CreateClient_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.CreatePage.Create_page));
        }

        private void UpdateClient_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Selected client

            if (Activities_lw.SelectedItem != null)
            {
                Client selectedClient = Activities_lw.SelectedItem as Client;

                new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ClientNS.UpdatePage.Client_Update_Delete), selectedClient);
            } else
            {
                // Validation content dialog
                
                
            }
        }
    }
}
