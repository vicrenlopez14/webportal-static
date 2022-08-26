using ProFind.Lib.AdminNS.Controllers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPageClient : Page
    {
        public ReadPageClient()
        {
            this.InitializeComponent();
            InitializeData();
        }

        private async void InitializeData()
        {
            ClientsListView.ItemsSource = await new PfClientService().ListObjectAsync();
        }

        private void ClientListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreateClientPage));
        }
    }
}
