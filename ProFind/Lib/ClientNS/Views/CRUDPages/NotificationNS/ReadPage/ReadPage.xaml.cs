using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.UpdatePage;
using ProFind.Lib.Global.Services;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUDPages.NotificationNS.ReadPage
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
            NotificationListView.ItemsSource = await APIConnection.GetConnection.GetNotificationsAsync();
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.NotificationNS.ReadPage.ReadPage));
        }

        private void NotificationListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var notification = e.ClickedItem as Notification;

            new InAppNavigationController().NavigateTo(typeof(UpdatePage), notification);
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
