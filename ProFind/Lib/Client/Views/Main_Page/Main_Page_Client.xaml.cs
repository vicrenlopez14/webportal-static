using System;
using System.Collections.Generic;
using UWP_ProFind.Lib.Global.Controllers;
using UWP_ProFind.Lib.Global.Views.Preferences_Page;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_ProFind.Lib.Client.Views.Main_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public sealed partial class Main_Page_Client : Page
    {

        static Dictionary<string, Type> DefinedPagesDictionary = new Dictionary<string, Type>()
        {
            {"Calendar_Page", typeof(Calendar_Page.Calendar_Page) },
            {"Dashboard_Page", typeof(Dashboard_Page.Dashboard_Page) },
            {"Notifications_Page", typeof(Notifications_Page.Notifications_Page) },
            {"Pays_Page", typeof(Pays_Page.Pays_Page) },
            {"", typeof(Dashboard_Page.Dashboard_Page) }
        };

        public Main_Page_Client()
        {
            this.InitializeComponent();
            new ClientNavigationController().Init(ClientsContentFrame);
        }
        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                new ClientNavigationController().NavigateTo(typeof(Preferences_Page));
                return;
            }

            var item = args.InvokedItemContainer;
            string selectedItemTag = item.Tag.ToString();

            if(selectedItemTag.Contains("_"))
            {
                var split = selectedItemTag.Split('_');
                // Pending

            }
            sender.Header = item.Content.ToString();




            new ClientNavigationController().NavigateTo(DefinedPagesDictionary[selectedItemTag]);
        }
    }
}
