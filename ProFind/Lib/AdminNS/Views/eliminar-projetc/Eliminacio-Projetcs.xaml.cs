using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Controllers;
using System.Collections.Generic;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.eliminar_projetc
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Eliminacio_Projetcs : Page
    {
        private bool _isFirstAdmin;

        public bool SucessfulCreation_tt { get; private set; }

        public Eliminacio_Projetcs()
        {
            this.InitializeComponent();
            GetProjectsList();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _isFirstAdmin = (bool)e.Parameter;

        }
        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> DeteteProfesionaList = new List<PFProject>();

            DeteteProfesionaList = await projectService.ListObjectAsync() as List<PFProject>;

            DeteteProfesionalListView.ItemsSource = DeteteProfesionaList;
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            PFProject Project = new PFProject();


            var respuesta = await new PfProjectService().Delete(Project.IdPJ);
            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new InAppNavigationController().GoBack();
                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));
                }
            }

        }
    }
}
