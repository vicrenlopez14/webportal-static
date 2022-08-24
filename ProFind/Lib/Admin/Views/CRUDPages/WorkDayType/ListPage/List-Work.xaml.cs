using Application.Models;
using Application.Services;
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

namespace ProFind.Lib.Admin.Views.CRUDPages.WorkDayType.ListPage
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
            var ClientService = new PFWorkDayTypeService();
            List<PFWorkDayType> ClientList = new List<PFWorkDayType>();

            ClientList = await ClientService.ListObjectAsync() as List<PFWorkDayType>;

            ClientListView.ItemsSource = ClientList;

        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFWorkDayType clickedItem = e.ClickedItem as PFWorkDayType;


        }
    }
}
