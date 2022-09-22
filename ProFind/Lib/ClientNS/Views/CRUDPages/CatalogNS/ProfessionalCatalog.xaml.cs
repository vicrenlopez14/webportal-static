using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUDPages.CatalogNS
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ProfessionalCatalog : Page
    {
        public ProfessionalCatalog()
        {
            this.InitializeComponent();
            GetProfessionalList();
        }

        private async void GetProfessionalList()
        {
            ProfessionalsListView.ItemsSource = await APIConnection.GetConnection.GetProfessionalsAsync();
        }

        private void btn_proposal_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProposalNS.Accept_or_Deny.AcceptOrDeny));
        }

        private  async void CreateClient_btn_Click(object sender, RoutedEventArgs e)
        {
            if (ProfessionalsListView.SelectedItem != null)
            {
                Professional selectedProfesional = ProfessionalsListView.SelectedItem as Professional;

                new InAppNavigationController().NavigateTo(typeof(Lib.ClientNS.Views.CRUDPages.ProposalsNS.CreatePage.CreatePage), selectedProfesional);
            }
            else
            {
                // Validation content dialog
                var dialog = new MessageDialog("You have to select a Professional.");
                await dialog.ShowAsync();

            }
           
        }
    }
}
