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

namespace ProFind.Lib.Admin.Views.ActivityCRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPageActivity : Page
    {
        PFProject parentProject;

        public ReadPageActivity()
        {
            this.InitializeComponent();

            InitializeData();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            parentProject = (PFProject)e.Parameter;
            PageHeader.Text = $"Activities related to {parentProject.TitlePJ}";
        }

        private async void InitializeData()
        {
        }

        private void AdminListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var activity = e.ClickedItem as PFActivity;

            new AdminNavigationController().NavigateTo(typeof(CreatePageActivity), new Tuple<PFProject, PFActivity>(parentProject, activity));
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new AdminNavigationController().NavigateTo(typeof(CreatePageActivity), (parentProject));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AdminNavigationController().NavigateTo(typeof(CreatePageActivity), (parentProject));
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AdminsListView.ItemsSource = await new PFActivityService().ListOfProject(parentProject.IdPJ);

        }
    }
}
