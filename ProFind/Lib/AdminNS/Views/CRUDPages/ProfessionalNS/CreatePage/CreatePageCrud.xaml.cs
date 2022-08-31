using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using ProFind.Lib.Global.Services.Models;
using System;
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        byte[] pictureBytes;

        private bool _isFirstAdmin;


        public BlankPage2()
        {
            this.InitializeComponent();
            loadUsefulThings();

            APIConnection.Init();
            var a = APIConnection.GetConnection;
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName1_tbx.Text))
            {

                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(LastName1_tbx.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Afp.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Dui.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(SeguroSocial.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(CodigoPostal.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Salario.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Email.Text))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(passwordBox.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
            else if (string.IsNullOrEmpty(Confirm_passwordBox.Password))
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }

            Global.Services.Models.Professional professional = new Global.Services.Models.Professional
            {
                NameP = FirstName1_tbx.Text + " " + LastName1_tbx.Text
            };

            // Nested objects

            professional.IdPfs1 = (profession_cbx.SelectedValue as Profession).IdPfs;
            professional.IdDp1 = (departamento.SelectedItem as Department).IdDp;
            professional.EmailP = Email.Text;
            professional.SexP = Sexo.Text == "Male";
            professional.PasswordP = passwordBox.Password;
            var selectedDate = FechadeIngreso.Date.Value;
            professional.HiringDateP = new DateOnly(selectedDate.Year, selectedDate.Month, selectedDate.Day, (int)selectedDate.DayOfWeek, selectedDate.DayOfYear);
            professional.Afpp = Afp.Text;
            professional.Duip = Dui.Text;
            professional.SalaryP = Salario.Value;
            professional.Isssp = SeguroSocial.Text;

            try
            {
                var respuesta = await APIConnection.GetConnection.PostProfessionalAsync(professional);

                SucessfulCreation_tt.IsOpen = true;

                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));
                }

            }
            catch
            {

            }


        }
        public async void loadUsefulThings()
        {
            var professionsList = await APIConnection.GetConnection.GetProfessionsAsync();
            profession_cbx.ItemsSource = professionsList;

            // Professions
            profession_cbx.ItemsSource = await APIConnection.GetConnection.GetProfessionsAsync();

            // Departments
            departamento.ItemsSource = await APIConnection.GetConnection.GetDepartmentsAsync();

            // Work-day types
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (_isFirstAdmin)
                FirstProfessional_tt.IsOpen = true;
        }

        private async void btnExaminar_Click(object sender, RoutedEventArgs e)
        {
            pictureBytes = await (await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            // center on Notre Dame Cathedral
            var center =
            new Geopoint(new BasicGeoposition()
            {
                Latitude = 13.722918,
                Longitude = -89.205192
            });

            // retrieve map
            await LocationMap.TrySetSceneAsync(MapScene.CreateFromLocationAndRadius(center, 3000));
        }
    }

}
