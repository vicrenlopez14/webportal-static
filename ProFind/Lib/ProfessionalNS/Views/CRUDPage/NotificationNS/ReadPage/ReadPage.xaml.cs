using ProFind.Lib.Global.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.ProfessionalNS.Controllers;
using System.Collections.Generic;
using System.Linq;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.ReadPage
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
            var loggedProfessional = LoggedProfessionalStore.LoggedProfessional;

            // Major lists
            var projects = await APIConnection.GetConnection.GetProjectsAsync();
            var notifications = await APIConnection.GetConnection.GetNotificationsAsync();

            // Projects where loggedProfessional is related
            var relatedProjects = projects.Where(p => p.IdP1 == loggedProfessional.IdP).ToList();

            // Notifications where loggedProfessional is related through a project
            var relatedNotifications = new List<Notification>();
            foreach (var project in projects)
            {
                var relatedNotificationsForThisProject = notifications.Where(n => n.IdPj2 == project.IdPj).ToList();
                relatedNotifications.AddRange(relatedNotificationsForThisProject);
            }

            NotificationListView.ItemsSource = relatedNotifications;
        }

        private void NotificationListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var notification = e.ClickedItem as Notification;


        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.CreatePage.CreatePage));
        }

        private void Add_btn_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.CreatePage.CreatePage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.UpdatePage.UpdatePage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}

