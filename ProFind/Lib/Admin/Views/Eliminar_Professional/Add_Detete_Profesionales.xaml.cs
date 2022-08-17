using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Add_Detete_Profesionales : Page
    {
        private bool _isFirstAdmin;

        public Add_Detete_Profesionales()
        {
            this.InitializeComponent();
            GetProjectsList();
        }

        public object SucessfulCreation_tt { get; private set; }

        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> DeteteProfesionaList = new List<PFProject>();

            DeteteProfesionaList = await projectService.ListObjectAsync() as List<PFProject>;

            DeteteProfesionalListView.ItemsSource = DeteteProfesionaList;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _isFirstAdmin = (bool)e.Parameter;

        }
        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            PFProfessional professional = new PFProfessional();


            var respuesta = await new PFProjectService().Delete(professional.IdP);
            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new clientNavigationController().GoBack();
                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
                }
            }


        }
    }
}
