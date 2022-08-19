using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Views.About_Page;
using ProFind.Lib.Global.Views.Preferences_Page;
using ProFind.Lib.Admin.Views.Estado_del_proyecto;
using ProFind.Lib.Admin.Views.Professionals_Page;
using ProFind.Lib.Admin.Views.CRUD;
using ProFind.Lib.Admin.Views.Project_CRUD;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Main_Page_Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Main_Page_Admin : Page
    {
        static Dictionary<string, Type> DefinedPagesDictionary = new Dictionary<string, Type>()
        {
            {"Administrators_Page", typeof(ReadPageAdmin) },
            {"Calendar_Page", typeof(ReadPageProject) },
            {"Professionals_Page", typeof(ActivesPage) },
            {"Clients_Page", typeof(QuickView_Page.QuickView_Page) },
            {"Preferences_Page", typeof(Preferences_Page) },
            {"About_Page",typeof(About_Page) },
            {"", typeof(Calendar_Page.Calendar_Page) }
        };

        public Main_Page_Admin()
        {
            this.InitializeComponent();
            new AdminNavigationController().Init(ContentFrame);
            new AdminNavigationController().NavigateTo(typeof(ReadPageAdmin));

        }

        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                new AdminNavigationController().NavigateTo(typeof(Preferences_Page));
                return;
            }

            var item = args.InvokedItemContainer;
            string selectedItemTag = item.Tag.ToString();

            if (selectedItemTag.Contains("_"))
            {
                var split = selectedItemTag.Split('_');
                // Pending
            }
            sender.Header = item.Content.ToString();

            try
            {
                navView.Header = item.Content;
                new AdminNavigationController().NavigateTo(DefinedPagesDictionary[selectedItemTag]);
            }
            catch
            {
                new AdminNavigationController().NavigateTo(DefinedPagesDictionary["Calendar_Page"]);
            }
        }

        private void navView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            new AdminNavigationController().GoBack();
        }
    }
}
