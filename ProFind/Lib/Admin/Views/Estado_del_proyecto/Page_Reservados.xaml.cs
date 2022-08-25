using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Estado_del_proyecto
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

        public async void GetProjectsList()

        {
            PfProjectService projectService = new PfProjectService();

            List<PFProject> PendienteProjectsList = new List<PFProject>();

            PendienteProjectsList = await projectService.ListObjectAsync() as List<PFProject>;

            ReservadosProjectsListView.ItemsSource = PendienteProjectsList;
        }
    }
}
