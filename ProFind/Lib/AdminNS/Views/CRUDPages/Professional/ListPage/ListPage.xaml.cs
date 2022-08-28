using Application.Models;
using Application.Services;
using ProFind.Lib.AdminNS.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace ProFind.Lib.AdminNS.Views.CRUDPages.Professional.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
        public ReadPage()
        {
            this.InitializeComponent();
            GetProjectsList();
        }
        public async void GetProjectsList()

        {
            var professionalService = new PFProfessionalService();

            List<PFProject> activeProfessionalsList = new List<PFProject>();

            IDictionary<string, string> criteries = new Dictionary<string, string>()
            {
                ["ActiveP"] = "1"
            };

            activeProfessionalsList = await professionalService.Search(criteries) as List<PFProject>;

            DashboardProfessionalsActiveListView.ItemsSource = activeProfessionalsList;
        }

        private async void ProjectsActiveListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFProfessional project = e.ClickedItem as PFProfessional;
            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.InitPage.InitPage), project);
        }

    }
}
