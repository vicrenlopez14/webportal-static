using ProFind.Lib.Global.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.Curriculum.CreatePage
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

            if (pickedFile != null)
            {

                UploadResume_btn.IsChecked = true;
                UploadResume_btn.Content = "Loaded file";
            }

            PDFPreview.LoadDocument(pickedFile);
        }
    }
}
