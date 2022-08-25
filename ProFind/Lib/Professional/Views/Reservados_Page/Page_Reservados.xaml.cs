using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Administradores
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Page_Reservados : Page
    {
        public Page_Reservados()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
       
        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> ActiveProjectsList = new List<PFProject>();

            ActiveProjectsList = await projectService.ListObjectAsync() as List<PFProject>;

            ReservadosProjectsListView.ItemsSource = ActiveProjectsList;
        }
    }
}
