using ProFind.Lib.Global.Services;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ActivityNS.ListPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListPage : Page
    {
        public ListPage()
        {
            this.InitializeComponent();
            GetProjectsList();
        }

        public async void GetProjectsList()
        {
            Activities_lw.ItemsSource = await APIConnection.GetConnection.GetProjectsAsync();
        }
    }
}
