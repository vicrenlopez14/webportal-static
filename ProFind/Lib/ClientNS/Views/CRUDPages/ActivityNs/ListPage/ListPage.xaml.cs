using ProFind.Lib.ClientNS.Controllers;
using ProFind.Lib.Global.Services;
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

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ActivityNs.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ListPage : Page
    {
        public ListPage()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            var loggendClien = LoggedClientStore.LoggedClient;
            var project = await APIConnection.GetConnection.GetProjectsAsync();
            var activities = await APIConnection.GetConnection.GetActivitiesAsync();

            var Relatedactivities = new List<Activity>();


            foreach (var Projects in project)
            {
                var RelatedActivitysForRelatedProject = activities.Where(n => n.IdPj1Navigation.IdC1 == loggendClien.IdC).ToList();
                Relatedactivities.AddRange(RelatedActivitysForRelatedProject);
            }

            ProjectsListView.ItemsSource = Relatedactivities;

        }
    }
}
