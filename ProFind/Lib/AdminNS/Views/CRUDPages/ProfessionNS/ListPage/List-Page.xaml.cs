using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Profession = ProFind.Lib.Global.Services.Profession;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Page : Page
    {
        Profession Id1 = new Profession();
        public List_Page()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            int idNo = (int)Id1.IdPfs;
            await APIConnection.GetConnection.GetProfessionAsync(idNo);
        }
    }
}
