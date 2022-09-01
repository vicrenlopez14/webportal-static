using ProFind.Lib.AdminNS.Controllers;
using System;
using System.Net;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.Crear_projects
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Create_Project : Page
    {
        private bool _isFirstAdmin;

        public Create_Project()
        {
            this.InitializeComponent();
        }

        public bool SucessfulCreation_tt { get; private set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _isFirstAdmin = (bool)e.Parameter;

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Project project = new Project();
            var profession = new Professional();

            project.ResponsibleProfessional = profession;
            project.TitlePJ = TitlePJ.Text;
            project.DescriptionPJ = DescriptionPJ.Text;
            project.Status = true ?ProjectStatus.Active : ProjectStatus.Inactive;

            var respuesta = await new ProjectService().Update(project);

            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new InAppNavigationController().GoBack();

                if (_isFirstAdmin)
                {
                    new InAppNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));
                }
            }

            if (string.IsNullOrEmpty(TitlePJ.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(DescriptionPJ.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        private void TxtDescription(object sender, TextChangedEventArgs e)
        {

        }

        private void TitlePJ_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

