using ProFind.Lib.Global.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using Project = ProFind.Lib.Global.Services.Project;
using ProFind.Lib.ProfessionalNS.Controllers;
using System.Linq;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProjectNS.ReadPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
        public ReadPage()
        {
            this.InitializeComponent();

            InitializeData();
        }

        private async void InitializeData()
        {
            var loggedProfessional = LoggedProfessionalStore.LoggedProfessional;
            var projects = await APIConnection.GetConnection.GetProjectsAsync();
            
            
            var relatedProjects = projects.Where(p => p.IdP1 == loggedProfessional.IdP).ToList();

            ProjectsListView.ItemsSource = relatedProjects;
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var project = e.ClickedItem as Project;

          
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.CRUDPage.ProjectNS.UpdatePage.UpdatePagePJ));
        }
    }
}
