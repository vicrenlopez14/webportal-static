using Application.Models;
using Application.Services;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;


namespace ProFind.Lib.Professional.Views.Dashboard_Page
{
    public sealed partial class Dashboard_Page : Page
    {
        public Dashboard_Page()
        {
            this.InitializeComponent();
            GetProjectsList();
        }
        public async void GetProjectsList()

        {
            PfProjectService projectService = new PfProjectService();

            List<PFProject> PendienteProjectsList = new List<PFProject>();

            PendienteProjectsList = await projectService.ListObjectAsync() as List<PFProject>;

            DashboardProjectsListView.ItemsSource = PendienteProjectsList;
        }   

        private void DashboardProjectsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = e.ClickedItem as PFProject;
            

        }
    }
}
