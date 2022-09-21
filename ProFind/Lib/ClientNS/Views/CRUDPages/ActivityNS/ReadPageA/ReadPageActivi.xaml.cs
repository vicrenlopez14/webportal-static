using ProFind.Lib.AdminNS.Controllers;
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

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ActivityNS.ReadPageA
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPageActivi : Page
    {
        
        Activity Id;
        public ReadPageActivi()
        {
            this.InitializeComponent();
            InitializeData();

        }
        private async void InitializeData()
        {
            var loggendClient = LoggedClientStore.LoggedClient;
            var project = await APIConnection.GetConnection.GetProjectsAsync();
            var Activity = await APIConnection.GetConnection.GetActivitiesAsync();

           var RelatedProjects = project.Where(c => c.IdC1 == loggendClient.IdC).ToList();

            var RelatedActivity =  new List<Activity>();

            foreach (var Projects in project)
            {
                var RelatedActivityForRelatedProject = Activity.Where(n => n.IdPj1 == Projects.IdPj).ToList();
                 RelatedActivity.AddRange(RelatedActivityForRelatedProject);
            }
            Activities_lw.ItemsSource = RelatedActivity;


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ActivityNS.SearchPage.SearchPage));
        }
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ActivityNS.SearchPage.SearchPage));
        }
       
    }
}
