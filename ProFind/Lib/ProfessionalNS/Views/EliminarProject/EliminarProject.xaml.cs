using ProFind.Lib.AdminNS.Controllers;
using System.Collections.Generic;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.EliminarProject
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
            var projectService = new ProjectService();

            List<Project> DeteteProfesionaList = new List<Project>();

            DeteteProfesionaList = await projectService.ListObjectAsync() as List<Project>;

            DeteteProfesionalListView.ItemsSource = DeteteProfesionaList;
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            var respuesta = await new ProjectService().Delete(IdToDelete);
            if (respuesta == HttpStatusCode.OK)
            {


                new InAppNavigationController().GoBack();
            }

        }

        private void DeteteProfesionalListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Project ToDeleteProject = (Project)e.ClickedItem;
            IdToDelete = ToDeleteProject.IdPJ;
        }
    }
}
