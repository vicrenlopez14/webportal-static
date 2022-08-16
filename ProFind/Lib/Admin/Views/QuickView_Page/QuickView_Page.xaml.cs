using Application.Models;
using Application.Services;
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

namespace ProFind.Lib.Admin.Views.QuickView_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QuickView_Page : Page
    {
        public QuickView_Page()
        {
            this.InitializeComponent();
            GetProjectsList();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        public async void GetProjectsList()

        {
            var projectService = new PfProjectService();

            List<PFProject> QuickViewList = new List<PFProject>();

            QuickViewList = await projectService.ListObjectAsync() as List<PFProject>;

            QuickViewListView.ItemsSource = QuickViewList;
        }
    }
}
