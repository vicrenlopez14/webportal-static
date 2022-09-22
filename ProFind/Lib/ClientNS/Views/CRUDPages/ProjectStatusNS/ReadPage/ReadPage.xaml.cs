using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Projectstatus = ProFind.Lib.Global.Services.Projectstatus;
using ProFind.Lib.Global.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ProjectStatusNS.ReadPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
        Projectstatus Id1 = new Projectstatus();
        public ReadPage()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            int idNo = int.Parse( Id1.IdPs);
            await APIConnection.GetConnection.GetProjectstatusAsync(idNo);
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
        }
    }
}
