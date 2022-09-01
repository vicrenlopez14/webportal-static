using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Admin_Page
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
            var adminService = new AdminService();
            List<Admin> adminList = new List<Admin>();

            adminList = await adminService.ListObjectAsync() as List<Admin>;

            AdminListView.ItemsSource = adminList;
        }

        private void AdminListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Admin clickedItem = (Admin)e.ClickedItem;

            

        }
    }
}  
          