using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.Notifications_Page
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class NotificationCreation_Page : Page
    {
        public NotificationCreation_Page()
        {
            this.InitializeComponent();
        }

        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnSend_Click_1(object sender, RoutedEventArgs e)
        {
            PFNotification ClientNotification = new PFNotification();
            ClientNotification.Project.ResponsibleClient.NameC = ClientName_txb.Text;
            ClientNotification.TitleN = Title_txb.Text;
            ClientNotification.DescriptionN = Description_txb.Text;
            ClientNotification.Project.ResponsibleProfessional.Profession.NamePFS = TypeProfession_txb.Text;

            var answer = new PFNotificationService();
            await answer.Create(ClientNotification);

            if (string.IsNullOrEmpty(ClientName_txb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Title_txb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Description_txb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(TypeProfession_txb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        private void btnSend_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
