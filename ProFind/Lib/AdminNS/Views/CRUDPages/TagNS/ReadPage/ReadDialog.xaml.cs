using ProFind.Lib.Global.Services;
using Syncfusion.Pdf;
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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.CurriculumNS.ReadPage
{
    public sealed partial class ReadDialog : ContentDialog
    {
        public ReadDialog(PdfDocument document)
        {
            

            PDFPreview.Load(document);
        }


        private async void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            const string projectIdSelected = "1";
            const string Titulo = "Carlitos";

            var results = await APIConnection.GetConnection.SearchActivitiesAsync(projectIdSelected, Titulo);
            var filterResults = await APIConnection.GetConnection.FilterActivitiesAsync(null, null, "asd", null, "sadsa");
            

            this.Hide();
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
