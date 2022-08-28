using ProFind.Lib.AdminNS.Controllers;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.ActivityCRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPageActivity : Page
    {
        PFProject parentProject;

        public ReadPageActivity()
        {
            this.InitializeComponent();

            InitializeData();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            parentProject = (PFProject)e.Parameter;
            PageHeader.Text = $"Activities related to {parentProject.TitlePJ}";
        }

        private async void InitializeData()
        {
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var activity = e.ClickedItem as PFActivity;

            new InAppNavigationController().NavigateTo(typeof(CreatePageActivity), new Tuple<PFProject, PFActivity>(parentProject, activity));
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePageActivity), (parentProject));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePageActivity), (parentProject));
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AdminsListView.ItemsSource = await new PFActivityService().ListOfProject(parentProject.IdPJ);

        }
    }
}
