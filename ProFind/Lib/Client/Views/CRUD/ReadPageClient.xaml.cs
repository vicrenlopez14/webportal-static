using Application.Services;
using ProFind.Lib.Global.Controllers;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPageClient : Page
    {
        public ReadPageClient()
        {
            this.InitializeComponent();
            InitializeData();
        }

        private async void InitializeData()
        {
            ClientsListView.ItemsSource = await new PfClientService().ListObjectAsync();
        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new ClientNavigationController().NavigateTo(typeof(CreateClientPage));
        }
    }
}
