using ProFind.Lib.AdminNS.Controllers;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Projects_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Projects_Page : Page
    {
        public Projects_Page()
        {
            this.InitializeComponent();
            GetProjectsList();
        }
        public async void GetProjectsList()
        {
            var projectService = new ProjectService();

            List<Project> ProjectsList = new List<Project>();

            ProjectsList = await projectService.ListObjectAsync() as List<Project>;

            ProjectsListView1.ItemsSource = ProjectsList;
        }

        private void ProjectsListView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Project clickeditem = e.ClickedItem as Project;

            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.InitPage.InitPage), clickeditem); 
        }
    }

    
}
