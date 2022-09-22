using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
using Project = ProFind.Lib.Global.Services.Project;
using System.Linq;
using ProFind.Lib.ProfessionalNS.Controllers;
using Windows.UI.Popups;
using System;

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProjectNS.ReadPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {

        public ReadPage()
        {
            this.InitializeComponent();

            InitializeData();
        }

        private async void InitializeData()
        {
            // Projects in which professional is related
            var projects = await APIConnection.GetConnection.GetProjectsAsync();
            var projectsOfThisProfessional = (from p in projects.ToList()
                                              where p.IdP1 == LoggedProfessionalStore.LoggedProfessional.IdP
                                              select p).ToList();

            ProjectsListView.ItemsSource = projectsOfThisProfessional;
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var project = e.ClickedItem as Project;

            new InAppNavigationController().NavigateTo(typeof(UpdatePage.Update_Project), project);
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePage.CreatePage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePage.CreatePage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ProjectNS.CreatePage.CreatePage));
        }

        private void UpdateProject_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ProjectNS.UpdatePage.Update_Project));
        }

        private async void DeleteProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedProject = ProjectsListView.SelectedItem as Project;
                await APIConnection.GetConnection.DeleteAdminAsync(selectedProject.IdPj);

                var dialog = new MessageDialog("Admin deleted successfully.");
                await dialog.ShowAsync();
            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode == 204)
                {
                    var dialog = new MessageDialog("Admin deleted successfully.");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("You have to select an admin.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                InitializeData();
            }
        }
    }
}
