using ProFind.Lib.ProfessionalNS.Controllers;
using ProFind.Lib.Global.Services;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProfessionalNS.ReadPage
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
            var professionalList = await APIConnection.GetConnection.GetAdminsAsync();
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var admin = e.ClickedItem as Admin;

            new InAppNavigationController().NavigateTo(typeof(UpdatePageAdmin), admin);
        }
    }
}
