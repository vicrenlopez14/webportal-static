using Microsoft.UI.Xaml.Controls;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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

namespace ProFind.Lib.Admin.Views.CRUDPages.Curriculum.CreatePage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
        private byte[] newCurriculum;

        public CreatePage()
        {
            this.InitializeComponent();
        }

        private async void AnimateButtons()
        {

        }

        private void PDFPreviewMode()
        {
            
        }

        private async void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            var pickedFile = await PickFileHelper.PickPDF();

            if (pickedFile.IsAvailable)
            {
                newCurriculum = await pickedFile.ToByteArrayAsync();

                if (newCurriculum != null)
                {
                    UploadResume_btn.IsChecked = true;
                    UploadResume_btn.Content = pickedFile.Name;
                }
            }
        }
    }
}
