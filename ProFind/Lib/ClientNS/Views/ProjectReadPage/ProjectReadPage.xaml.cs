using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.ProjectReadPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProjectReadPage : Page
    {

        public ProjectReadPage()
        {
            this.InitializeComponent();
            GetProjectList();
        }

        public async void GetProjectList()
        {
            var projectServices = new PfProjectService();

            List<PFProject> ListProject = new List<PFProject>();



            ListProject = await projectServices.ListProjectsByUserAsync(PfClientService.client.IdC) as List<PFProject>;

            ProjectListView.ItemsSource = ListProject;  
        }

    }
}
