using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using ProFind.Lib.Global.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Page : Page
    {
        Notification Id1 = new Notification();
        public List_Page()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            Activities_lw.ItemsSource = APIConnection.GetConnection.GetNotificationAsync(Id1.IdN);

        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.CreatePage.CreatePage));
        }

        private void Add_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.UpdatePage.UpdatePage));
        }
    }
}
