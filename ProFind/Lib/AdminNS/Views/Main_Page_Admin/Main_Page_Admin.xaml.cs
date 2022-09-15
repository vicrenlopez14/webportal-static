using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.ProfessionalNS.Controllers;
using ProFind.Lib.Global.Views.About_Page;
using ProFind.Lib.Global.Views.Preferences_Page;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.Main_Page_Admin
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
            {"Professionals_Page", typeof(ReadPageProfessional) },
            {"Clients_Page", typeof(ReadPageClient) },
            {"Preferences_Page", typeof(Preferences_Page) },
            {"About_Page",typeof(About_Page) },
            {"", typeof(Calendar_Page.Calendar_Page) }
        };

        public Main_Page_Admin()
        {
            this.InitializeComponent();
            new InAppNavigationController().Init(ContentFrame);
            new InAppNavigationController().NavigateTo(typeof(ReadPageAdmin));
        }

        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                new Controllers.InAppNavigationController().NavigateTo(typeof(Preferences_Page));
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
                new Controllers.InAppNavigationController().NavigateTo(DefinedPagesDictionary[selectedItemTag]);
            }
            catch
            {
                new Controllers.InAppNavigationController().NavigateTo(DefinedPagesDictionary["Calendar_Page"]);
            }
        }

        private void navView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            new Controllers.InAppNavigationController().GoBack();
        }
    }
}
