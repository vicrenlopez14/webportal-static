using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Status_Page
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Status_Page : Page
    {
        public Status_Page()
        {
            this.InitializeComponent();
            GetProjectsList();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();
            List<PFProject> statusList = new List<PFProject>();

            statusList = await projectService.ListObjectAsync() as List<PFProject>;

            StatusListView1.ItemsSource = statusList;
        }
    }
}
