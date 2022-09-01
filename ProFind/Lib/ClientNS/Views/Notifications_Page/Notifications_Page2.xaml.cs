using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;
using ProFind.Lib.Global.Services.Models;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.Notifications_Page
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Notifications_Page2 : Page
    {
        public Notifications_Page2()
        {
            this.InitializeComponent();

            GetProjectsList();
        }

        public async void GetProjectsList()
        {
            var projectService = new ProjectService();
            List<Project> clientNotificationList = new List<Project>();

            clientNotificationList = await projectService.ListObjectAsync() as List<Project>;

            CientNotificationListView.ItemsSource = clientNotificationList;
        }
    }
}
