using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Views.Preferences_Page;
using ProFind.Lib.Admin.Views.Estado_del_proyecto;
using ProFind.Lib.Admin.Views.Professionals_Page;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.Main_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public sealed partial class Main_Page_Client : Page
    {

        static Dictionary<string, Type> DefinedPagesDictionary = new Dictionary<string, Type>()
        {
            {"Dashboard_Page", typeof(Lib.Professional.Views.Dashboard_Page.Dashboard_Page) },
            {"Proyects_Page", typeof(Page_Activos) },
            {"Notifications_Page", typeof(Actives_Page) },
            {"Pays_Page", typeof(Pays_Page.Pays_Page) },
            {"Catalog_Page", typeof(Actives_Page) },
            {"Activities_Page", typeof(Actives_Page) },
            {"", typeof(Dashboard_Page.Dashboard_Page) }
        };

        public Main_Page_Client()
        {
            this.InitializeComponent();
            new ClientNavigationController().Init(ClientsContentFrame);
            new ClientNavigationController().NavigateTo(typeof(Page_Activos));
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

            if (selectedItemTag.Contains("_"))
            {
                var split = selectedItemTag.Split('_');
                // Pending

            }
            sender.Header = item.Content.ToString();




            new ClientNavigationController().NavigateTo(DefinedPagesDictionary[selectedItemTag]);
        }
    }
}
