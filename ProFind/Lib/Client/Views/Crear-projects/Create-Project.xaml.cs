using Application.Models;
using Application.Services;
using Google.Protobuf.WellKnownTypes;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.Crear_projects
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
            PFProject project = new PFProject();
            var profession = new PFProfessional();

            project.ResponsibleProfessional = profession;
            project.TitlePJ = TitlePJ.Text;
            project.DescriptionPJ = DescriptionPJ.Text;
            project.Status = true ?PFProjectStatus.Active : PFProjectStatus.Inactive;

            var respuesta = await new PfProjectService().Update(project);

            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new InAppNavigationController().GoBack();

                if (_isFirstAdmin)
                {
                    new InAppNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
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

