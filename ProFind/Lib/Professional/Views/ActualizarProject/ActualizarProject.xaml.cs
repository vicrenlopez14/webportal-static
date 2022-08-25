using ProFind.Lib.Admin.Controllers;
using System;
using System.Net;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Professional.Views.ActualizarProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActualizarProject : Page
    {
        public ActualizarProject()
        {
            this.InitializeComponent();
        }

        private async void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            PFProject project = new PFProject();
            var profession = new PFProfessional();

            project.ResponsibleProfessional = profession;

            project.TitlePJ = TitlePJ.Text;
            project.DescriptionPJ = DescriptionPJ.Text;
            project.TotalPricePJ = float.Parse(TotalPricePJ.Text);
            project.Status = Inactivo.IsChecked == true ? PFProjectStatus.Active : PFProjectStatus.Inactive;

            var respuesta = await new PfProjectService().Update(project);

            if (respuesta == HttpStatusCode.OK)
            {
                new InAppNavigationController().GoBack();

            }

            if (string.IsNullOrEmpty(TitlePJ.Text)){
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(DescriptionPJ.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(TotalPricePJ.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }
    }
}
