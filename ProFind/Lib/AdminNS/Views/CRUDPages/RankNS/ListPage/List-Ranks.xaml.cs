using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Rank = ProFind.Lib.Global.Services.Rank;
using ProFind.Lib.Global.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.RankNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Ranks : Page
    {
        
        public List_Ranks()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
          
          Activities_lw.ItemsSource =  await APIConnection.GetConnection.GetRanksAsync();
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.RankNS.CreatePage.Create_Page));

        }

        private void Add_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.RankNS.UpdatePage.Update_Page_Rank));

        }
    }
}
