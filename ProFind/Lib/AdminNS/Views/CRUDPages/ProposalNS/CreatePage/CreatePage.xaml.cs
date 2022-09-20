using ProFind.Lib.Global.Helpers;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProposalNS.CreatePage
{
    public sealed partial class CreatePage : Page
    {

        public Professional SelectedProfessional;

        public CreatePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            try
            {
                this.SelectedProfessional = (Professional)e.Parameter;
            }
            catch
            {
                SelectedProfessional = new Professional();
            } finally
            {
                LoadPageData();
            }
        }

        private void LoadPageData()
        {
            ProfessionalImage_img.Source = SelectedProfessional.PictureP.ToBitmapImage().ToWriteableBitmap();
            ProfessionalProfession_tb.Text = SelectedProfessional.IdPfs1Navigation.NamePfs;
            ProfessionalDepartment_tb.Text = SelectedProfessional.IdDp1Navigation.NameDp;
            ProfessionalHiringDate_tb.Text = SelectedProfessional.HiringDateP.ToString();
        }

        private async void ViewCurriculum_btn_Click(object sender, RoutedEventArgs e)
        {
            await new CurriculumNS.ReadPage.ReadDialog(SelectedProfessional.CurriculumP.ToPdfLoadedDocument()).ShowAsync();
        }
    }
}
