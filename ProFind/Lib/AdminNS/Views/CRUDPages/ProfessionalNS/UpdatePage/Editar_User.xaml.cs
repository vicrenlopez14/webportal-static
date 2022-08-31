using System.Net;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Editar_User : Page
    {

        public bool SucessfulCreation_tt { get; private set; }

        byte[] pictureBytes;
        private PFClient client;

        public Editar_User()
        {
            this.InitializeComponent();
        }

        private void TxtNumEmpleado(object sender, TextChangedEventArgs e)
        {

        }

        private void TxFIstName(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtLastName(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEmail(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPuesto(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMetodoDePago(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtSalario(object sender, TextChangedEventArgs e)
        {

        }

        private void txtJornada(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

        }

        private async void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            PFProfessional professional = new PFProfessional();
         
            professional.NameP = Fistname.Text + LastName.Text;
            professional.EmailP = Email.Text;
            professional.SalaryP = Salario.Text;
            professional.PasswordP = Confirm_passwordBox.Password;


            var respuesta = await new PFProfessionalService().Update(professional);
            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new Controllers.InAppNavigationController().GoBack();
            }
        }

        private async void btnExaminar_Click(object sender, RoutedEventArgs e)
        {

            pictureBytes = await(await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private async Task btnCancelarCambios_ClickAsync(object sender, RoutedEventArgs e)
        {
            string IdToDelete = client.IdC;

            var result = await new PfClientService().Delete(IdToDelete);

            new GlobalNavigationController().GoBack();
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().GoBack();
        }

        private void btnCancelarCambios_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
