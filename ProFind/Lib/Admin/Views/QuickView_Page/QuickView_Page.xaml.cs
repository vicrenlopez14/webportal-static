using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.QuickView_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QuickView_Page : Page
    {
        public QuickView_Page()
        {
            this.InitializeComponent();
            GetProjectsList();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> QuickViewList = new List<PFProject>();

            QuickViewList = await projectService.ListObjectAsync() as List<PFProject>;

            QuickViewListView.ItemsSource = QuickViewList;
        }
    }
}
