using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpdatePageAdmin : Page
    {
        PFAdmin toManipulate = new PFAdmin();

        public UpdatePageAdmin()
        {
            this.InitializeComponent();
        }
        private async void loadUsefulthings()
        {
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            toManipulate = (PFAdmin)e.Parameter;
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            // Reset with the same ID
            toManipulate = new PFAdmin()
            {
                IdA = toManipulate.IdA,
            };
        }


        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await new PFAdminService().Update(toManipulate);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await new PFAdminService().Delete(toManipulate.IdA);
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new AdminNavigationController().GoBack();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            toManipulate.PictureA = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private void FirstName1_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.NameA = FirstName1_tbx.Text;
        }

        private void Email_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            toManipulate.EmailA = Email_tbx.Text;
        }

        private void Phone_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
        {
            toManipulate.TelA = ((int)Phone_tbx.Value).ToString();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            toManipulate.PasswordA = Password_tbx.Password;
        }
    }
}
