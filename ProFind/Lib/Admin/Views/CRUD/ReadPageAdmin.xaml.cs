﻿using ProFind.Lib.Admin.Controllers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            ProjectsListView.ItemsSource = await new PFAdminService().ListObjectAsync();
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var admin = e.ClickedItem as PFAdmin;

            new InAppNavigationController().NavigateTo(typeof(UpdatePageAdmin), admin);
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(CreatePageAdmin));
        }
    }
}
