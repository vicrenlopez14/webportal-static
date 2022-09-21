using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.ClientNS.Views.InitPage;
using ProFind.Lib.Global.Services;
using Professional = ProFind.Lib.Global.Services.Professional;


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
            GetProjectsList();
        }
        public async void GetProjectsList()

        {
            await APIConnection.GetConnection.GetProfessionalsAsync();
           
        }

        private async void ProjectsActiveListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Professional project = e.ClickedItem as Professional;
            new InAppNavigationController().NavigateTo(typeof(InitPage), project);
        }

    }
}
