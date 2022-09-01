using ProFind.Lib.Global.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services.Models;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.DeletePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Delete : Page
    {
        Professional toManipulate = new Professional();
        byte[] pictureBytes;


        public Delete()
        {
            this.InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            await new ProfessionalService().Delete(toManipulate.IdP);
        }

        private async void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            FirstName1_tbx.Text = toManipulate.NameP;
            LastName1_tbx.Text = toManipulate.NameP;
            passwordBox.Password = toManipulate.PasswordP;
            Afp.Text = toManipulate.AFPP;
            Dui.Text = toManipulate.DUIP;
            SeguroSocial.Text = toManipulate.ISSSP;
            Email.Text = toManipulate.EmailP;
            Salario.Text = toManipulate.SalaryP;
            await new ProfessionalService().Update(toManipulate);
        }

        private async void btnExaminar_Click(object sender, RoutedEventArgs e)
        {
            toManipulate.PictureP = await(await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

    }
}
