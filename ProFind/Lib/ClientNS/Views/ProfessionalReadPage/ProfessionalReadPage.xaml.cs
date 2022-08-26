using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.ProfessionalReadPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfessionalReadPage : Page
    {
        public ProfessionalReadPage()
        {
            this.InitializeComponent();
        }

        private async void InitializeData()
        {
            ProfessionalsListView.ItemsSource = await new PFProfessionalService().ListObjectAsync();
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
