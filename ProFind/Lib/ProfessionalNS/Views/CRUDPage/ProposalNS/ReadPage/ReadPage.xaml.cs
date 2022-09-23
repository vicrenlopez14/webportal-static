using ProFind.Lib.Global.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.AdminNS.Views.CRUDPages.AdminNS.CreatePage;
using Proposal = ProFind.Lib.Global.Services.Proposal;
using Windows.UI.Popups;
using System;
using System.Linq;
using ProFind.Lib.ProfessionalNS.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProposalNS.ReadPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
       
        public ReadPage()
        {
            this.InitializeComponent();

            InitializeData();
        }

        private async void InitializeData()
        {
            var result = await APIConnection.GetConnection.GetProposalsAsync();
            var projectsOfThisProfessional = (from pp in result.ToList()
                                                   where pp.IdP3 == LoggedProfessionalStore.LoggedProfessional.IdP
                                                   select pp).ToList();
            Activities_lw.ItemsSource = projectsOfThisProfessional;

            var a = new Tag { };
        }

        private void ProposalListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var proposal = e.ClickedItem as Proposal;

        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProposalNS.Accept_or_Deny.AcceptOrDeny));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var obj = Activities_lw.SelectedItem as Proposal;
                new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProposalNS.Accept_or_Deny.AcceptOrDeny), obj);
            }
            catch
            {
                var dialog = new MessageDialog("You have to select a proposal.");
                await dialog.ShowAsync();
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Proposal obj = Activities_lw.SelectedItem as Proposal;
                await APIConnection.GetConnection.DeleteProposalAsync(obj.IdPp);
                var dialog = new MessageDialog("The proposal has been deleted");
                await dialog.ShowAsync();
            }
            catch (ProFindServicesException ex)
            {
                if(ex.StatusCode>=200 && ex.StatusCode <= 205)
                {
                    var dialog = new MessageDialog("You have to select a proposal.");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("There was a problem while eliminating the proposal, try again later.");
                    await dialog.ShowAsync();
                }
            }
            finally
            {
                InitializeData();
            }
        }
    }
}
