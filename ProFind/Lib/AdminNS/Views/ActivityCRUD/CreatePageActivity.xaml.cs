using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.ActivityCRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePageActivity : Page
    {

        private string[] status = Enum.GetNames(typeof(ProjectStatus));
        private List<Professional> professionals = new List<Professional>();
        private List<string> professionalStrings = new List<string>();

        private List<Client> clients = new List<Client>();
        private List<string> clientStrings = new List<string>();

        private Activity toManipulate = new Activity();
        private Project parentProject;
        public CreatePageActivity()
        {
            this.InitializeComponent();
            loadUsefulThings();
        }

        public async void loadUsefulThings()
        {
            (professionals, professionalStrings) = await new ProfessionalService().GetComboboxChoices();
            (clients, clientStrings) = await new ClientService().GetComboboxChoices();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is Tuple<Project, Activity>)
            {
                var param = (Tuple<Project, Activity>)e.Parameter;
                parentProject = param.Item1;
                toManipulate = param.Item2;
                FillFields(toManipulate);
                ManipulationMode();
            }
            else if (e.Parameter is Project)
            {
                parentProject = (Project)e.Parameter;
                CreationMode();
            }
        }
        private void FillFields(Activity incomingActivity)
        {
            SelectedPicture_pp.Source = incomingActivity.PictureA.ToBitmapImage();
            Title_tb.Text = incomingActivity.TitleA;
            Description_tb.Text = incomingActivity.DescriptionA;
            ExpectedBegin_dp.Date = incomingActivity.ExpectedBeginA;
            ExpectedEnd_dp.Date = incomingActivity.ExpectedEndA;
        }

        private void CreationMode()
        {
            PageTitle.Text = "Creation";
            PageSubtitle.Text = "Create a new activity for your project.";
            Create_btn.Visibility = Visibility.Visible;
            Update_btn.Visibility = Visibility.Collapsed;
            Reset_btn.Visibility = Visibility.Collapsed;
            Delete_btn.Visibility = Visibility.Collapsed;
        }

        private void ManipulationMode()
        {
            PageTitle.Text = "Manipulation";
            PageSubtitle.Text = "Update, delete and reset.";
            Create_btn.Visibility = Visibility.Collapsed;
            Update_btn.Visibility = Visibility.Visible;
            Reset_btn.Visibility = Visibility.Visible;
            Delete_btn.Visibility = Visibility.Visible;
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            toManipulate.IdPJ1 = parentProject.IdPJ;

            var result = await new ActivityService().Create(toManipulate);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new InAppNavigationController().GoBack(parentProject);
            }
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await new ActivityService().Update(toManipulate);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await new ActivityService().Delete(toManipulate.IdA);
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            // Reset with the same ID
            toManipulate = new Activity()
            {
                IdA = toManipulate.IdA,

            };
            loadUsefulThings();
        }


        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            var pickedFile = await PickFileHelper.PickImage();
            toManipulate.PictureA = await (pickedFile).ToByteArrayAsync();
            SelectedPicture_tbk.Text = pickedFile.Name;
        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.TitleA = Title_tb.Text;
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.DescriptionA = Description_tb.Text;
        }

        private void ExpectedBegin_dp_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            toManipulate.ExpectedBeginA = ExpectedBegin_dp.Date;
        }

        private void ExpectedEnd_dp_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            toManipulate.ExpectedEndA = ExpectedBegin_dp.Date;
        }
    }
}
