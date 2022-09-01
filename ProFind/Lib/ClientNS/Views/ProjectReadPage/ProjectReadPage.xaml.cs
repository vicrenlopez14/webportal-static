using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;

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
            var projectServices = new ProjectService();

            List<Project> ListProject = new List<Project>();



            ListProject = await projectServices.ListProjectsByUserAsync(ClientService.client.IdC) as List<Project>;

            ProjectListView.ItemsSource = ListProject;  
        }

    }
}
