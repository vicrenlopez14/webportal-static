using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.Pays_Page
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Realized_Page : Page
    {
        public Realized_Page()
        {
            this.InitializeComponent();
            GetProjectRealizedList();
        }

        public async void GetProjectRealizedList()
        {
            var projectService = new ProjectService();
            List<Project> projectRealizedList = new List<Project>();

            projectRealizedList = await projectService.ListObjectAsync() as List<Project>;

            clientsRealizedView.ItemsSource = projectRealizedList;  
        }
    }
}
