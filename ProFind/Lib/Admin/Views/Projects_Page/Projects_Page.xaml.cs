using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Projects_Page
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

            new InAppNavigationController().NavigateTo(typeof(Lib.Admin.Views.InitPage.InitPage), clickeditem); 
        }
    }

    
}
