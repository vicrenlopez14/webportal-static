﻿using ProFind.Lib.AdminNS.Controllers;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage
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
            var professionalService = new ProfessionalService();

            List<Project> activeProfessionalsList = new List<Project>();

            IDictionary<string, string> criteries = new Dictionary<string, string>()
            {
                ["ActiveP"] = "1"
            };

            activeProfessionalsList = await professionalService.Search(criteries) as List<Project>;

            DashboardProfessionalsActiveListView.ItemsSource = activeProfessionalsList;
        }

        private async void ProjectsActiveListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Professional project = e.ClickedItem as Professional;
            new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.InitPage.InitPage), project);
        }

    }
}