using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Estado_del_proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Page_PendientesCancelacionxaml : Page
    {
        public Page_PendientesCancelacionxaml()
        {
            this.InitializeComponent();


            GetProjectsList();
        }

        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> PedientesProjectsList = new List<PFProject>();

            PedientesProjectsList = await projectService.ListObjectAsync() as List<PFProject>;

            PendientesProjectsListView.ItemsSource = PedientesProjectsList;
        }
    }
}
