using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;
using ProFind.Lib.Global.Services.Models;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.Reservados_Page
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
            var projectService = new ProjectService();

            List<Project> ActiveProjectsList = new List<Project>();

            ActiveProjectsList = await projectService.ListObjectAsync() as List<Project>;

            ReservadosProjectsListView.ItemsSource = ActiveProjectsList;
        }
    }
}
