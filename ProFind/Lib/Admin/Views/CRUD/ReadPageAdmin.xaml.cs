using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
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
    public sealed partial class ReadPageAdmin : Page
    {
        public ReadPageAdmin()
        {
            this.InitializeComponent();

            InitializeData();
        }

        private async void InitializeData()
        {
            AdminsListView.ItemsSource = await new PFAdminService().ListObjectAsync();
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var admin = e.ClickedItem as PFAdmin;

            new AdminNavigationController().NavigateTo(typeof(UpdatePageAdmin), admin);
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new AdminNavigationController().NavigateTo(typeof(CreatePageAdmin));
        }
    }
}
