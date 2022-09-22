using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.AdminNS.Controllers;
using System.Collections.Generic;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Page : Page
    {
        public List_Page()
        {
            this.InitializeComponent();
            InitializeData();
        }
        
        private async void InitializeData()
        {
            Notifications_lw.ItemsSource = (await APIConnection.GetConnection.GetNotificationsAsync()) as List<Notification>;
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.CreatePage.CreatePage));
        }

        private void Add_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.UpdatePage.UpdatePage));
        }

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.UpdatePage.UpdatePage));
        }
    }
}
