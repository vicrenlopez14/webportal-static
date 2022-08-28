using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Client_List
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

           
        }
    }
}
