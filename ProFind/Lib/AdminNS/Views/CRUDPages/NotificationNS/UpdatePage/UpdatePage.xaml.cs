using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.NotificationNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        Notification toManipulate = new Notification();

        private byte[] imageBytes;

        public UpdatePage()
        {
            this.InitializeComponent();
            AddEvents();

        }

        private void AddEvents()
        {
            Title_tb.OnEnterNextField();
            Description_tb.OnEnterNextField();

        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            Title_tb.Text = "";
            Description_tb.Text = "";
        }


        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            byte[] da = toManipulate.PictureN = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

            var toUpdapteNoti = new Notification { IdN = toManipulate.IdN, TitleN = Title_tb.Text, DescriptionN = Description_tb.Text, DateTimeIssuedN = toManipulate.DateTimeIssuedN, IdPj2 = toManipulate.IdPj2, IdPj2Navigation = toManipulate.IdPj2Navigation, PictureN = imageBytes };

            await APIConnection.GetConnection.PutNotificationAsync(toManipulate.IdN, toUpdapteNoti);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteNotificationAsync(toManipulate.IdN);
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

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
           
        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(Lib.ClientNS.Views.CRUDPages.NotificationNS.ReadPage.ReadPage), toManipulate);
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
    }
}
