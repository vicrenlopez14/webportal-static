using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Estado_del_proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Page_Activos : Page
    {
        public Page_Activos()
        {
            this.InitializeComponent();

            GetProjectsList();
        }

        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> ActiveProjectsList = new List<PFProject>();

            ActiveProjectsList = await projectService.ListObjectAsync() as List<PFProject>;

            ActiveProjectsListView.ItemsSource = ActiveProjectsList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
