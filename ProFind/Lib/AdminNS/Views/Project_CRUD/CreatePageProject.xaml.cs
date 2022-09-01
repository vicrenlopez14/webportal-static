using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Views.Estado_del_proyecto;
using ProFind.Lib.Global.Services.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Project_CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePageProject : Page
    {
        private Project newObject = new Project();

        private string[] status = Enum.GetNames(typeof(ProjectStatus));
        private List<Professional> professionals = new List<Professional>();
        private List<string> professionalStrings = new List<string>();

        private List<Client> clients = new List<Client>();
        private List<string> clientStrings = new List<string>();

        public CreatePageProject()
        {
            this.InitializeComponent();
            loadUsefulThings();
        }

        public async void loadUsefulThings()
        {
            (professionals, professionalStrings) = await new ProfessionalService().GetComboboxChoices();
            (clients, clientStrings) = await new ClientService().GetComboboxChoices();

            InitialStatus_cb.ItemsSource = status;
            Professional_cb.ItemsSource = professionalStrings;
            Client_cb.ItemsSource = clientStrings;
        }


        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Title_tb.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
                return;
            }
            else if (string.IsNullOrEmpty(Description_tb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
                return;
            }

            var result = await new ProjectService().Create(newObject);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new InAppNavigationController().GoBack();
            }

        }

        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            newObject.PicturePJ = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.TitlePJ = Title_tb.Text;
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.DescriptionPJ = Description_tb.Text;
        }



        private void TotalPrice_tb_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
        {
            newObject.TotalPricePJ = (float)sender.Value;
        }

        private void InitialStatus_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProjectStatus selectedStatus = ProjectStatus.Inactive;

            if (InitialStatus_cb.SelectedIndex == 1)
                selectedStatus = ProjectStatus.Active;

            newObject.Status = selectedStatus;
            newObject.IdPS1 = selectedStatus == ProjectStatus.Inactive ? "0" : "1";
        }

        private void Professional_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newObject.ResponsibleProfessional = professionals[Professional_cb.SelectedIndex];
        }

        private void Client_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newObject.ResponsibleClient = clients[Client_cb.SelectedIndex];
        }
    }
}
