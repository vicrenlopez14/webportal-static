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

namespace ProFind.Lib.Admin.Views.Admin_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminList : Page
    {
        public AdminList()
        {
            this.InitializeComponent();
        }

        public async void GetAdminList()
        {
            var adminService = new PFAdminService();
            List<PFAdmin> adminList = new List<PFAdmin>();

            adminList = await adminService.ListObjectAsync() as List<PFAdmin>;

            AdminListView.ItemsSource = adminList;
        }

        private void AdminListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            PFAdmin clickedItem = (PFAdmin)e.ClickedItem;

            new AdminNavigationController().NavigateTo(typeof(Lib.Admin.Views.UpdateDeleteClient.UpdateDeleteClient), clickedItem);

        }
    }
}   `
          