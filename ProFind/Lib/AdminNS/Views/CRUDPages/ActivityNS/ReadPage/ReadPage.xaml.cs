using ProFind.Lib.Global.Services;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ActivityNS.ReadPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPage : Page
    {
        public ReadPage()
        {
            this.InitializeComponent();
        }

        public Activity ModelActivity { get; set; }
        public Activity ModelActivityDebug { get; set; } = new Activity
        {
            TitleA = "Lorem ipsum",
            DescriptionA = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
            IdA = "",
            IdPj1 = "",
            IdT1 = "",
            PictureA = new byte[3],
        };

    }
}
