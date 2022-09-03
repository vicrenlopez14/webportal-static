using ProFind.Lib.Global.Services;
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

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProjectNS.CreatePage
{
    public sealed partial class SelectProfessionalDialog : ContentDialog
    {
        public static Professional SelectedProfessional { get; set; }
        public SelectProfessionalDialog()
        {
            this.InitializeComponent();
        }

        private  async void LoadData()
        {
            ProfessionalsListView.ItemSource = await APIConnection.GetConnection.GetProfessionalsAsync();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ProfessionalsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedProfessional = (Professional)e.ClickedItem;
        }
    }
}
