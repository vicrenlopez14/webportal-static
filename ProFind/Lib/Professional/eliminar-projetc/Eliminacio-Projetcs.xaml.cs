using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Professional.Controllers;
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

namespace ProFind.Lib.Professional.eliminar_projetc
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Eliminacio_Projetcs : Page
    {

       

        public Eliminacio_Projetcs()
        {
            this.InitializeComponent();
            GetProjectsList2();




        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            _isFirstAdmin = (bool)e.Parameter;

        }
        public async void GetProjectsList2()

        {
            var projectService = new PfProjectService();

            List<PFProject> DeteteProfesionaList = new List<PFProject>();

            DeteteProfesionaList = await projectService.ListObjectAsync() as List<PFProject>;

            DeteteProfesionalListView.ItemsSource = DeteteProfesionaList;
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            PFProject Project = new PFProject();


            var respuesta = await new PFProjectService().Delete(Project.IdPJ);
            if (respuesta == HttpStatusCode.OK)
            {


                SucessfulCreation_tt = true;
                new AdminNavigationController().GoBack();
                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
                }
            }

        }
    }
}
