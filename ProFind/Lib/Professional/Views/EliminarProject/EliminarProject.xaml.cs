using Application.Models;
using Application.Services;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Professional.Views.EliminarProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EliminarProject : Page
    {

        private string IdToDelete;

        public EliminarProject()
        {
            this.InitializeComponent();
            GetProjectsList2();
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

            var respuesta = await new PfProjectService().Delete(IdToDelete);
            if (respuesta == HttpStatusCode.OK)
            {


                new ProfessionalNavigationController().GoBack();
            }

        }

        private void DeteteProfesionalListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFProject ToDeleteProject = (PFProject)e.ClickedItem;
            IdToDelete = ToDeleteProject.IdPJ;
        }
    }
}
