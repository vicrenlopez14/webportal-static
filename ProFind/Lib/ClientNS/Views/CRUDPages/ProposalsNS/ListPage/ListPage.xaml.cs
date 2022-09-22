using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.ClientNS.Controllers;
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

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ListPAge : Page
    {
        Proposal Id;
        public ListPAge()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            var loggendClient = LoggedClientStore.LoggedClient;
            var Proposals = await APIConnection.GetConnection.GetProposalsAsync();
            var RelatePropals = Proposals.Where(c => c.IdC3 == loggendClient.IdC).ToList();
           
           

            Activities_lw.ItemsSource = RelatePropals;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.SeachPage.SearchPage));
        
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.CreatePage.CreatePage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.UpdatePage.UpdatePage));
        }
    }
}
