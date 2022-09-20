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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Global.Views.ProfessionalsCatalog
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfessionalsCatalog : Page
    {
        List<Professional> CandidateProfessionals;
        Profession SelectedProfession;
        Professional SelectedProfessional;
 
        bool ReadyToMakeProposal = false;
        
        public ProfessionalsCatalog()
        {
            this.InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            RestartVars();

            LoadCandidates();
        }

        private async void LoadCandidates()
        {
            CandidateProfessionals = await APIConnection.GetConnection.FilterPr
        }

        private void RestartVars()
        {
            {
                StepsFlipView_fv.SelectedIndex = 0;
                SelectedProfession = null;
                SelectedProfessional = null;
                ReadyToMakeProposal = false;
            }
        }

        private void UpdateControlStates()
        {
            SelectedProfessionSection_sp.Visibility = SelectedProfession == null ? Visibility.Visible : Visibility.Collapsed;
            SelectedProfessionalSection_sp.Visibility = SelectedProfessional == null ? Visibility.Visible : Visibility.Collapsed;
            MakeAProposal_btn.IsEnabled = ReadyToMakeProposal;
        }

        private void ProfessionsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedProfession = e.ClickedItem as Profession;
            StepsFlipView_fv.SelectedIndex++;
            UpdateControlStates();
        }

        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }
    }
}
