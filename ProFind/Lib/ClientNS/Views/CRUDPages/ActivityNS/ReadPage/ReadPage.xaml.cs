using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Services;
using Project = ProFind.Lib.Global.Services.Project;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ActivityNS.ReadPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
        Activity Id; 
        public ReadPage()
        {
            this.InitializeComponent();

            InitializeData();
        }

        private async void InitializeData()
        {
            Activities_lw.ItemsSource = await APIConnection.GetConnection.GetActivityAsync(Id.IdA);
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var project = e.ClickedItem as Project;

           // new InAppNavigationController().NavigateTo(typeof(UpdatePageProject), project);
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ActivityNS.SearchPage.SearchPage));
        }
    }
}
