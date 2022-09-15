using ProFind.Lib.ProfessionalNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        Notification toManipulate = new Notification();

        public UpdatePage()
        {
            this.InitializeComponent();
        }
        private async void loadUsefulthings()
        {

            SelectedPicture_pp.Source = toManipulate.PictureN.ToBitmapImage();
            Title_tb.Text = toManipulate.TitleN ?? "";
            Description_tb.Text = toManipulate.DescriptionN ?? "";

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            toManipulate = (Notification)e.Parameter;
            loadUsefulthings();
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            // Reset with the same ID
            toManipulate = new Notification()
            {
                IdN = toManipulate.IdN,

            };
            loadUsefulthings();
        }


        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await new NotificationService().Update(toManipulate);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await new NotificationService().Delete(toManipulate.IdN);
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            toManipulate.PictureN = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            var pickedFile = await PickFileHelper.PickImage();
            toManipulate.PictureN = await (pickedFile).ToByteArrayAsync();
            SelectedPicture_tbk.Text = pickedFile.DisplayName;
        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.TitleN = Title_tb.Text;
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.DescriptionN = Description_tb.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ReadPage.ReadPage), toManipulate);
        }
    }
}
