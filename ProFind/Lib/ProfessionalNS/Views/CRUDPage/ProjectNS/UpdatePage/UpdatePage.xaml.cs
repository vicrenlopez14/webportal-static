using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ProFind.Lib.AdminNS.Controllers;
using Client = ProFind.Lib.Global.Services.Client;
using Professional = ProFind.Lib.Global.Services.Professional;
using Project = ProFind.Lib.Global.Services.Project;
using Projectstatus = ProFind.Lib.Global.Services.Projectstatus;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ProjectNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        Project toManipulate = new Project();
        private List<Professional> professionals = new List<Professional>();

        private List<Client> clients = new List<Client>();

        public UpdatePage()
        {
            this.InitializeComponent();
        }
        private async void loadUsefulthings()
        {
            professionals = await APIConnection.GetConnection.GetProfessionalsAsync() as List<Professional>;
            clients = await APIConnection.GetConnection.GetClientsAsync() as List<Client>;

            Professional_cb.ItemsSource = professionals;
            Client_cb.ItemsSource = clients;

            SelectedPicture_pp.Source = toManipulate.PicturePj.ToBitmapImage();
            Title_tb.Text = toManipulate.TitlePj ?? "";
            Description_tb.Text = toManipulate.DescriptionPj ?? "";
            TotalPrice_tb.Text = ((int)toManipulate.TotalPricePj).ToString();
            Professional_cb.SelectedItem =  toManipulate.IdP1Navigation;
            Client_cb.SelectedItem = toManipulate.IdC1Navigation;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            toManipulate = (Project)e.Parameter;
            loadUsefulthings();
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            // Reset with the same ID
            toManipulate = new Project()
            {
                IdPj = toManipulate.IdP1,

            };
            loadUsefulthings();
        }


        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.PutProjectAsync(toManipulate.IdPj, toManipulate);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteProjectAsync(toManipulate.IdPj);
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            toManipulate.PicturePj = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            var pickedFile = await PickFileHelper.PickImage();
            toManipulate.PicturePj = await (pickedFile).ToByteArrayAsync();
            SelectedPicture_tbk.Text = pickedFile.DisplayName;
        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.TitlePj = Title_tb.Text;
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.DescriptionPj = Description_tb.Text;
        }

        private void TotalPrice_tb_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
        {
            toManipulate.TotalPricePj = (int)TotalPrice_tb.Value;
        }

        private void InitialStatus_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Projectstatus selectedStatus = InitialStatus_cb.SelectedItem as Projectstatus;

            toManipulate.IdPs1Navigation = selectedStatus;
            toManipulate.IdPs1 = selectedStatus.IdPs;
        }

        private void Professional_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            toManipulate.IdP1Navigation = professionals[Professional_cb.SelectedIndex];
            toManipulate.IdP1 = professionals[Professional_cb.SelectedIndex].IdP;

        }

        private void Client_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            toManipulate.IdC1Navigation = Client_cb.SelectedItem as Client;
            toManipulate.IdC1 = clients[Client_cb.SelectedIndex].IdC;
   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(Lib.ClientNS.Views.CRUDPages.ActivityNS.ReadPage.ReadPage), toManipulate);
        }
    }
}
