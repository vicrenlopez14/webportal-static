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
            FirstName1_tbx.Text = toManipulate.NameA;
            Email_tbx.Text = toManipulate.EmailA;
            Phone_tbx.Text = toManipulate.TelA;
            Picture_img.Source = toManipulate.PictureA.ToBitmapImage();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            toManipulate = (PFAdmin)e.Parameter;
            loadUsefulthings();
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            // Reset with the same ID
            toManipulate = new PFAdmin()
            {
                IdA = toManipulate.IdA,
            };

            loadUsefulthings();
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

       
    }
}
