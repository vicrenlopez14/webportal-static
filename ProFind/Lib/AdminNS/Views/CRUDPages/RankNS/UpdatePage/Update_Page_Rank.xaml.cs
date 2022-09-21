using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Rank = ProFind.Lib.Global.Services.Rank;
using ProFind.Lib.Global.Helpers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.RankNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Update_Page_Rank : Page
    {
        Rank pro = new Rank();
        public Update_Page_Rank()
        {
            this.InitializeComponent();
        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            int idNo = (int)pro.IdR;
            var toUpdateProfession = new Rank { NameR = Name_tb.Text };
            await APIConnection.GetConnection.PutRankAsync(idNo, toUpdateProfession);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            int idNo = (int)pro.IdR;

            await APIConnection.GetConnection.DeleteRankAsync(idNo);
        }

        private void Name_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }
    }
}
