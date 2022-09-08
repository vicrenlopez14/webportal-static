using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;

using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProjectNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
        private Project newObject = new Project();

        private string[] status = Enum.GetNames(typeof(Projectstatus));
        private List<Professional> professionals = new List<Professional>();
        private List<string> professionalStrings = new List<string>();

        private List<Client> clients = new List<Client>();
        private List<string> clientStrings = new List<string>();


        public CreatePage()
        {
            this.InitializeComponent();
            Cargar();

        }

        private async void Cargar()
        {
            InitialStatus_cb.ItemsSource = await APIConnection.GetConnection.GetProjectstatusesAsync();

            Professional_cb.ItemsSource = await APIConnection.GetConnection.GetProfessionalsAsync();
            Client_cb.ItemsSource = await APIConnection.GetConnection.GetClientsAsync();

        }


        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            byte[] da = toManipulate.PicturePj = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

            var toCreateClien = new Project("", Title_tb.Text, Description_tb.Text, da, TotalPrice_tb.Value, (InitialStatus_cb.SelectedItem as Projectstatus).IdPs, (Professional_cb.SelectedItem as Professional).IdP, (Client_cb.SelectedItem as Client).IdC);


            var result = await APIConnection.GetConnection.PostProjectAsync(toCreateClien);

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





        }


        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            newObject.PicturePj = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.TitlePj = Title_tb.Text;
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.DescriptionPj = Description_tb.Text;

        }



        private void TotalPrice_tb_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
        {
            newObject.TotalPricePj = (float)sender.Value;

        }

        private void InitialStatus_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Projectstatus selectedStatus = Projectstatus.Inactive;

            if (InitialStatus_cb.SelectedIndex == 1)
                selectedStatus = Projectstatus.Active;

            newObject.Status = selectedStatus;
            newObject.IdPS1 = selectedStatus == ProjectStatus.Inactive ? "0" : "1";
        }

        private void Professional_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Client_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialogResult result = await new SelectProfessionalDialog().ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                newObject.IdP1 = SelectProfessionalDialog.SelectedProfessional.IdP;
            }
        }
    }

}
