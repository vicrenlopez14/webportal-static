using ProFind.Lib.Admin.Controllers;
using System.Collections.Generic;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Professional.Views.EliminarProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EliminarProject : Page
    {

        private string IdToDelete;

        public EliminarProject()
        {
            this.InitializeComponent();
            GetProjectsList2();
        }
        public async void GetProjectsList2()

        {
            var projectService = new PfProjectService();

            List<PFProject> DeteteProfesionaList = new List<PFProject>();

            DeteteProfesionaList = await projectService.ListObjectAsync() as List<PFProject>;

            DeteteProfesionalListView.ItemsSource = DeteteProfesionaList;
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            var respuesta = await new PfProjectService().Delete(IdToDelete);
            if (respuesta == HttpStatusCode.OK)
            {


                new InAppNavigationController().GoBack();
            }

        }

        private void DeteteProfesionalListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFProject ToDeleteProject = (PFProject)e.ClickedItem;
            IdToDelete = ToDeleteProject.IdPJ;
        }
    }
}
