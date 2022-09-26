using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ActivityNs.ListaPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ListPage : Page
    {
        public ListPage()
        {
            this.InitializeComponent();
        }
        private async void InitializeData()
        {
            ProjectsListView.ItemsSource = await APIConnection.GetConnection.GetActivitiesAsync();

            ProjectsListView.ItemsSource = await APIConnection.GetConnection.GetActivitiesAsync() as List<Activity>;
        }
        private async void Delete_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                if (ProjectsListView.SelectedItem != null)
                {
                    var obj = ProjectsListView.SelectedItem as Activity;
                    await APIConnection.GetConnection.DeleteActivityAsync(obj.IdAc);

                }
                else
                {

                    var dialog = new MessageDialog("You have to select a Activity.");
                    await dialog.ShowAsync();

                }

            }
            catch (ProFindServicesException ex)
            {
                if (ex.StatusCode >= 200 && ex.StatusCode <= 205)
                {
                    var dialog = new MessageDialog("The Activity has been deleted");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("There was a problem while creating the Activity, try again later");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                InitializeData();
            }
        }

        private async void Update_Click_1(object sender, RoutedEventArgs e)
        {
            if (ProjectsListView.SelectedItem != null)
            {
                Activity lectedActivi = ProjectsListView.SelectedItem as Activity;
                new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ActivityNs.UpdatePage.UpdatePage), lectedActivi);
            }
            else
            {
                // Validation content dialog
                var dialog = new MessageDialog("You have to select a Activity.");
                await dialog.ShowAsync();

            }
        }
    }
}
