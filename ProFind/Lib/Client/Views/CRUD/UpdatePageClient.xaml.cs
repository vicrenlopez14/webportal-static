using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpdatePageClient : Page
    {

        PFClient ToManipulate = new PFClient();

        public UpdatePageClient()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ToManipulate = (PFClient)e.Parameter;
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            ToManipulate = new PFClient()
            {
                IdC = ToManipulate.IdC,
            };
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName1_tbx.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Email_tbx.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Password_tbx.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }

            await new PfClientService().Update(ToManipulate);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await new PfClientService().Delete(ToManipulate.IdC);
        }

        private async void Back_btn_Click(object sender, RoutedEventArgs e)
        {   
            new InAppNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ToManipulate.PictureC = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private void FirstName1_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            ToManipulate.NameC = FirstName1_tbx.Text;
        }

        private void Email_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            ToManipulate.EmailC = FirstName1_tbx.Text;
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ToManipulate.PasswordC = Password_tbx.Password;
        }
        
    }
}
