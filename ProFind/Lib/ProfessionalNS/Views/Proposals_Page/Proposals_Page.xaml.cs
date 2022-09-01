using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;
using ProFind.Lib.Global.Services.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.Proposals_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Proposals_Page : Page
    {
        public Proposals_Page()
        {
            this.InitializeComponent();
        }
        public async void GetProjectsList()

        {

            var projectService = new ProjectService();

            List<Project> NotifiProfesionaList = new List<Project>();

            NotifiProfesionaList = await projectService.ListObjectAsync() as List<Project>;

            ProposalsProfesionalListView.ItemsSource = NotifiProfesionaList;
        }
    }
}
