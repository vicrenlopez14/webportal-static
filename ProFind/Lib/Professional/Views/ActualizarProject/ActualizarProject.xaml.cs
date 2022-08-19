using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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
                new AdminNavigationController().GoBack();

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
