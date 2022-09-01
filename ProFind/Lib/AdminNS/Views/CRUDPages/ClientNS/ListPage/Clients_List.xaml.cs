using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage
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
            var ClientService = new ClientService();
            List<Client> ClientList = new List<Client>();

            ClientList = await ClientService.ListObjectAsync() as List<Client>;

            ClientListView.ItemsSource = ClientList;    

        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Client clickedItem = e.ClickedItem as Client;

           
        }
    }
}
