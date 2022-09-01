using ProFind.Lib.AdminNS.Controllers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;
using ProFind.Lib.Global.Services.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Project_CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPageProject : Page
    {
        public ReadPageProject()
        {
            this.InitializeComponent();

            InitializeData();
        }

        private async void InitializeData()
        {
            AdminsListView.ItemsSource = await new ProjectService().ListObjectAsync();
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var project = e.ClickedItem as Project;

            new InAppNavigationController().NavigateTo(typeof(UpdatePageProject), project);
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePageProject));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePageProject));
        }
    }
}
