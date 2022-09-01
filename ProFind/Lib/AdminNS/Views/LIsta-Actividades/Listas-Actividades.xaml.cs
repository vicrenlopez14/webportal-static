using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.LIsta_Actividades
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Lista_Clientes : Page
    {
        public Lista_Clientes()
        {
            this.InitializeComponent();
            GetProjectsList();
        }
        public async void GetProjectsList()

        {
            var projectService = new Activity();

            List<Activity> ActiveProjectsList = new List<Activity>();

            ActiveProjectsList = await projectService.ListObjectAsync() as List<Activity>;

            ActiveProjectsListView.ItemsSource = ActiveProjectsList;
        }
    }
}
