using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using ProFind.Lib.ClientNS.Controllers;
using ProFind.Lib.ProfessionalNS.Controllers;
using System.Linq;
using ProFind.Lib.AdminNS.Controllers;
using Windows.UI.Popups;
using System;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProjectNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Page_Projects : Page
    {
        public List_Page_Projects()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            
                // Projects of the loggedProfessoinal
                var projects = await APIConnection.GetConnection.GetProjectsAsync();
                var ForThisProfessional = projects.Where(x => x.IdP1 == LoggedProfessionalStore.LoggedProfessional.IdP).ToList();

                ProjectsListView.ItemsSource = ForThisProfessional;
            
        }

        private void AddProject_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void UpdateProject_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.CRUDPage.ProjectNS.UpdatePage.Update_Project));
        }

        private async void CompleteProject_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // The project has been mark as completed and deleted. A notification has been sent to the Client.

            var project = (Project)ProjectsListView.SelectedItem;

            if (project == null)
            {
                // Success dialog
                var dialog = new MessageDialog("No Project was selected.");
                await dialog.ShowAsync();
            }

            try
            {
                await APIConnection.GetConnection.DeleteProjectAsync(project.IdPj);

                // Success dialog
                var dialog = new MessageDialog("Project completed successfully");
                await dialog.ShowAsync();
            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode >= 200 && ex.StatusCode <= 300)
                {
                    var dialog = new MessageDialog("Project completed successfully");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("Error completing project");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                new InAppNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.CRUDPage.ProjectNS.ListPage.List_Page_Projects));

            }

        }
    }
}
