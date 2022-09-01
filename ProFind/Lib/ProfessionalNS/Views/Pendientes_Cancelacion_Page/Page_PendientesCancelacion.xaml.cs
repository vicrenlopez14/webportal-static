using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.Pendientes_Cancelacion_Page
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Page_PendientesCancelacion : Page
    {
        public Page_PendientesCancelacion()
        {
            this.InitializeComponent();
            GetPendienteCancel();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        public async void GetPendienteCancel()
        {
            var PendienteCancelService = new ProjectService();

            List<Project> PendienteCancelList = new List<Project>();

            PendienteCancelList = await PendienteCancelService.ListObjectAsync() as List<Project>;

            PendientesCancelacionListView.ItemsSource = PendienteCancelList;
        }

    }
}
