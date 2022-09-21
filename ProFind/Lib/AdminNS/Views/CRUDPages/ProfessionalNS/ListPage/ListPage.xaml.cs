using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.ClientNS.Views.InitPage;
using ProFind.Lib.Global.Services;
using Professional = ProFind.Lib.Global.Services.Professional;
using System.Collections.Generic;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
        Professional Id1 = new Professional();
        public ReadPage()
        {
            this.InitializeComponent();
            GetProfessionalsList();
        }
        public async void GetProfessionalsList()
        {
            ProfessionalsListView.ItemsSource = await APIConnection.GetConnection.GetProfessionalsAsync() as List<Professional>;
        }

        private async void ProjectsActiveListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Professional professional = e.ClickedItem as Professional;
            
            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage.ReadPage), professional);
        }

    }
}
