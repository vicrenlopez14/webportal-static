using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Client = ProFind.Lib.Global.Services.Client;
using Professional = ProFind.Lib.Global.Services.Professional;
using Project = ProFind.Lib.Global.Services.Project;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProjectNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Update_Project : Page
    {
        Project toManipulate = new Project();
        private byte[] imageBytes;
        public Update_Project()
        {
            this.InitializeComponent();
            Cargar();
            AddEvents();
        }
        private void AddEvents()
        {
            Title_tb.OnEnterNextField();
            Description_tb.OnEnterNextField();
            TotalPrice_tb.OnEnterNextField();

        }
        private async void Cargar()
        {
            Professional_cb.ItemsSource = await APIConnection.GetConnection.GetProfessionalsAsync();
            Client_cb.ItemsSource = await APIConnection.GetConnection.GetClientsAsync();

        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            byte[] da = toManipulate.PicturePj = await(await PickFileHelper.PickImage()).ToByteArrayAsync();

            var toCreateClien = new Project { TitlePj = Title_tb.Text, DescriptionPj = Description_tb.Text, PicturePj = imageBytes, TotalPricePj = int.Parse(TotalPrice_tb.Text), IdP1 = (Professional_cb.SelectedItem as Professional).IdP, IdC1 = (Client_cb.SelectedItem as Client).IdC };

            await APIConnection.GetConnection.PutProjectAsync(toManipulate.IdPj,toCreateClien);

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

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteProjectAsync(toManipulate.IdPj);
        }
        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
        }

        private void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InitialStatus_cb_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {

        }

        private void InitialStatus_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Professional_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Client_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Title_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;

        }

        private void Description_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void TotalPrice_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyFloats(e, TotalPrice_tb.Text)) e.Handled = true;
            else e.Handled = false;
        }
    }
}
