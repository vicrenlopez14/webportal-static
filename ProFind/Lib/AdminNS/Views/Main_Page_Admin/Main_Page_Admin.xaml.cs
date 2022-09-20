using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.Global.Views.About_Page;
using ProFind.Lib.Global.Views.Preferences_Page;
using ProFind.Lib.Global.Services;
using ProFind.Lib.Global.Helpers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Main_Page_Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Main_Page_Admin : Page
    {
       

        public Main_Page_Admin()
        {
            this.InitializeComponent();
            new InAppNavigationController().Init(ContentFrame);

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

            var page = PagesDefinition.DefinedPagesDictionary[selectedItemTag];

            if (page != null)
            {
                try
                {
                    navView.Header = item.Content;
                    new Controllers.InAppNavigationController().NavigateTo(page);
                }
                catch
                {
                    new Controllers.InAppNavigationController().NavigateTo(PagesDefinition.DefinedPagesDictionary["Preferences_Page"]);
                }
            }
          
        }

        private void navView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            new Controllers.InAppNavigationController().GoBack();
        }
    }
}
