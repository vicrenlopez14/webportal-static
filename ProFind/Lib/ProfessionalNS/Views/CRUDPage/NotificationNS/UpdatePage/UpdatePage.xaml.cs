using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        Notification toManipulate;
        private byte[] imageBytes;

        public UpdatePage()
        {
            this.InitializeComponent();
            AddEvents();
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

       
      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ReadPage.ReadPage), toManipulate);
        }

        private void Title_tb_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private async void Update_btn_Click_1(object sender, RoutedEventArgs e)
        {

            var ToCreateClient = new Notification { IdN = toManipulate.IdN, TitleN = Title_tb.Text, DescriptionN = Description_tb.Text, PictureN = imageBytes };


            
            await APIConnection.GetConnection.PutNotificationAsync(toManipulate.IdN, ToCreateClient);
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.ReadPage.ReadPage));

        }

        private void Reset_btn_Click_1(object sender, RoutedEventArgs e)
        {
            
            toManipulate = new Notification()
            {
                IdN = toManipulate.IdN,

            };
            loadUsefulthings();
        }

        private async void Delete_btn_Click_1(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteNotificationAsync(toManipulate.IdN);
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.ReadPage.ReadPage));

        }

        private void Back_btn_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void PictureSelection_btn_Click_1(object sender, RoutedEventArgs e)
        {
            var pickedFile = await PickFileHelper.PickImage();
            toManipulate.PictureN = await(pickedFile).ToByteArrayAsync();
            SelectedPicture_tbk.Text = pickedFile.DisplayName;
           imageBytes = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
         
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.NotificationNS.ReadPage.ReadPage));
       
        }

        private void Title_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void Description_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void AddEvents()
        {
            Title_tb.OnEnterNextField();
            Description_tb.OnEnterNextField();
        }
    }
}
