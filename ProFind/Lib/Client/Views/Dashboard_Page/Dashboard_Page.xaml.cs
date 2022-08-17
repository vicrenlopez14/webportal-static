using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.Dashboard_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dashboard_Page : Page
    {
        public Dashboard_Page()
        {
            this.InitializeComponent();

        }

        public async void GetProjectList()
        {
            PfProjectService projectService = new PfProjectService();
            List<PFProject> projects = new List<PFProject>();

            IDictionary<string, string> criteries = new Dictionary<string, string>()
            {
                ["IdC1"] = PfClientService.client.IdC
            };

            projects = await projectService.Search(criteries) as List<PFProject>;

            DashboardProjectsListView.ItemsSource = projects;
        }

        private void DashboardProjectsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = e.ClickedItem as PFProject;
            new AdminNavigationController().NavigateTo(typeof(Admin.Views.Add_Detete_Profesionales), clickedItem);
        }
    }
}
