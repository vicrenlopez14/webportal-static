using Application.Services;
using ProFind.Lib.Global.Controllers;
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

namespace ProFind.Lib.Global.Views.ServerNotAvailable
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ServerNotAvailablePage : Page
    {
        public ServerNotAvailablePage()
        {
            this.InitializeComponent();

            Retry();
        }

        public static async void Retry()
        {

            while (true)
            {
                try
                {
                    // Retry
                    await WebAPIConnection.IsServerAlive();

                    // If everything went ok, go back
                    new GlobalNavigationController().GoBack();
                }
                catch
                {
                    // If exception is thrown again, try back
                    continue;
                }
            }
        }

        private void Hyperlink_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {

        }
    }
}
