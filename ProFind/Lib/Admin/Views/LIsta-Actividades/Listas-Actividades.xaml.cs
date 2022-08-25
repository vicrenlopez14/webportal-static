using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Lista_clientes
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
            var projectService = new PFActivity();

            List<PFActivity> ActiveProjectsList = new List<PFActivity>();

            ActiveProjectsList = await projectService.ListObjectAsync() as List<PFActivity>;

            ActiveProjectsListView.ItemsSource = ActiveProjectsList;
        }
    }
}
