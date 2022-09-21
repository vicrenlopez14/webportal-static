using ProFind.Lib.Global.Views.About_Page;
using ProFind.Lib.Global.Views.Preferences_Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFind.Lib.Global.Helpers
{
    public static class PagesDefinition
    {
        public static Dictionary<string, Type> DefinedPagesDictionary = new Dictionary<string, Type>()
        {
            #region AdminPages
            {"ProjectsOverview_Page", null},
            //Projects overview
            {"Projects_Page", typeof(Lib.AdminNS.Views.CRUDPages.ProjectNS.ListPage.List_Page_Projects)},
            {"Activity_Page", typeof(Lib.AdminNS.Views.CRUDPages.ActivityNS.ListPage.ListPageActivi) },
            //People
            {"Administrators_Page", typeof(Lib.AdminNS.Views.CRUDPages.AdminNS.ListPage.ListPageAdmin)},
            {"Clients_Page", typeof(Lib.AdminNS.Views.CRUDPages.ClientNS.ListPage.Clients_List)},
            {"Professionals_Page", typeof(Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage.ReadPage)},
            //Notification center
            {"GeneralNotifications_Page", typeof(Lib.AdminNS.Views.CRUDPages.NotificationNS.ListPage.List_Page)},
            {"ProposalNotifications_Page", null },
            #endregion

            #region ClientPages
            {"Proposals_Page_Client", typeof(Lib.ClientNS.Views.CRUDPages.ProposalsNS.ListPage.ListPAge) },
            #endregion

            //Footer
            {"Preferences_Page", typeof(Preferences_Page)},
            {"Profile_Page", typeof(About_Page) },
        };
    }
}
