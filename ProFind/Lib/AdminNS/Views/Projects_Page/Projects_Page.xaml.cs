using ProFind.Lib.AdminNS.Controllers;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

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
            var projectService = new PfProjectService();

            List<PFProject> ProjectsList = new List<PFProject>();

            ProjectsList = await projectService.ListObjectAsync() as List<PFProject>;

            ProjectsListView1.ItemsSource = ProjectsList;
        }

        private void ProjectsListView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFProject clickeditem = e.ClickedItem as PFProject;

            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.InitPage.InitPage), clickeditem); 
        }
    }

    
}
