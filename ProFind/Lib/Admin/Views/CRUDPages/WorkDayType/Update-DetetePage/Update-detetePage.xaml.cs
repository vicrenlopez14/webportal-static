using ProFind.Lib.Admin.Controllers;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.CRUDPages.WorkDayType.Update_DetetePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Update_detetePage : Page
    {
       PFWorkDayType toManipulate = new PFWorkDayType();

        public Update_detetePage()
        {
            this.InitializeComponent();
        }
        private async void loadUsefulthings()
        {
            Name1_tbx.Text = toManipulate.NameWDT;
           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            toManipulate = (PFWorkDayType)e.Parameter;
            loadUsefulthings();
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            await new PFWorkDayTypeService().Update(toManipulate);

            if (string.IsNullOrEmpty(Name1_tbx.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
           
        }

        private void name(object sender, TextChangedEventArgs e)
        {
          Name1_tbx.Text = toManipulate.NameWDT;
        }

        private void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            toManipulate = new PFWorkDayType()
            {
                IdWDT = toManipulate.IdWDT,
            };

            loadUsefulthings();
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            await new PFWorkDayTypeService().Delete(toManipulate.IdWDT);

            if (string.IsNullOrEmpty(Name1_tbx.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        private async void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }
    }
}
