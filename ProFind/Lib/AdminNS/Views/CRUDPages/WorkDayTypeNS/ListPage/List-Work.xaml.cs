using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.WorkDayTypeNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Work : Page
    {
        public List_Work()
        {
            this.InitializeComponent();
            GetClientList();
        }

        public async void GetClientList()
        {
            var ClientService = new WorkDayTypeService();
            List<WorkDayType> ClientList = new List<WorkDayType>();

            ClientList = await ClientService.ListObjectAsync() as List<WorkDayType>;

            ClientListView.ItemsSource = ClientList;

        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            WorkDayType clickedItem = e.ClickedItem as WorkDayType;


        }
    }
}
