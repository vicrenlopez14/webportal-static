using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePageAdmin : Page
    {
        private PFAdmin newObject = new PFAdmin();
        private List<PFRank> ranks = new List<PFRank>();
        private List<string> rankStrings = new List<string>();

        public CreatePageAdmin()
        {
            this.InitializeComponent();
            loadUsefulThings();
        }

        public async void loadUsefulThings()
        {
            ranks = (List<PFRank>)await new PfRankService().ListObjectAsync();

            foreach (var rank in ranks)
            {
                rankStrings.Add(rank.NameR);
            }

            Rank_cb.ItemsSource = null;
            Rank_cb.ItemsSource = rankStrings;
            Rank_cb.SelectedIndex = 0;
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            var result = await new PFAdminService().Create(newObject);

            if (result == System.Net.HttpStatusCode.OK)
            {
                new InAppNavigationController().GoBack();
            }
            if (string.IsNullOrEmpty(Name_tb.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Email_tb.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Password_pb.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        private async void PictureSelection_btn_Checked(object sender, RoutedEventArgs e)
        {
            PictureSelection_btn.IsChecked = !PictureSelection_btn.IsChecked;
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            newObject.PictureA = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

        }

        private void Name_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.NameA = Name_tb.Text;
        }

        private void Email_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.EmailA = Email_tb.Text;
        }

        private void Password_pb_PasswordChanged(object sender, RoutedEventArgs e)
        {
            newObject.PasswordA = Password_pb.Password;
        }

        private void PhoneNumber_tb_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
        {
            newObject.TelA = ((int)sender.Value).ToString();
        }

        private void Rank_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newObject.IdR1 = ranks[Rank_cb.SelectedIndex].IdR;
            newObject.Rank = ranks[Rank_cb.SelectedIndex];
        }
    }
}
