using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
using Professional = ProFind.Lib.Global.Services.Professional;
using ProFind.Lib.Global.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ProfessionalNS.ReadPage
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
            GetProjectsList();
        }
        public async void GetProjectsList()

        {
            DashboardProfessionalsActiveListView.ItemsSource = await APIConnection.GetConnection.GetProfessionalAsync(Id1.IdP);

        }

        private async void ProjectsActiveListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Professional project = e.ClickedItem as Professional;
          
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ProfessionalNS.SearchPage.SearchPageP));
        }
    }
}
