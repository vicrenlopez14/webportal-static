using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ProfessionalInformationAddition : Page
    {
        private List<Profession> professions = new List<Profession>();

        private List<Department> departments = new List<Department>();

        byte[] pictureBytes;

        private bool _isFirstAdmin;
        public ProfessionalInformationAddition()
        {
            this.InitializeComponent();
            loadUsefulThings();

        }

        public async void loadUsefulThings()
        {
            // Professions
            profession_cbx.ItemsSource = await APIConnection.GetConnection.GetProfessionsAsync();

            // Departments
            departamento.ItemsSource = await APIConnection.GetConnection.GetDepartmentsAsync();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _isFirstAdmin = (bool)e.Parameter;

        }

        private void Selection_Sexo(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtNumEmpleado(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtNum_SeguroSocial(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPuestoDeTrabajo(object sender, TextChangedEventArgs e)
        {

        }

        private void Selection_Departamento(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtDui(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCodigo_Postal(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEmail(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMetodoDePago(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtSalario(object sender, TextChangedEventArgs e)
        {

        }

        private void Selection_Tipo_Jornada(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtAFP(object sender, TextChangedEventArgs e)
        {

        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Professional professional = new Professional();
            professional.NameP = FirstName1_tbx.Text + " " + LastName1_tbx.Text;

            // Nested objects
            var profession = new Profession();
            profession = professions.Where(x => x.NameS == profession_cbx.SelectedValue).First();

            professional.Department = new Department();
            professional.Department = departments.Where(x => x.NameDP == departamento.SelectedValue).First();

            professional.WorkDayType = new WorkDayType();
            professional.WorkDayType = workdaytypes.Where(x => x.NameWDT == Jornada.SelectedValue).First();

            professional.Profession = profession;
            professional.EmailP = Email.Text;
            professional.SexP = Sexo.Text == "Male";
            professional.PasswordP = passwordBox.Password;

            professional.HiringDateP = DateTime.Now;
            professional.AFPP = Afp.Text;
            professional.DUIP = Dui.Text;
            professional.SalaryP = Salario.Text;
            professional.ISSSP = SeguroSocial.Text;

            var respuesta = await new ProfessionalService().Create(professional);
            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt.IsOpen = true;

                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));
                }
            }
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


        }

        private void ToggleThemeTeachingTip2_ActionButtonClick(TeachingTip sender, object args)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.ProfessionalNS.Views.InitPage.InitPage));
        }

        private void ToggleThemeTeachingTip2_CloseButtonClick(TeachingTip sender, object args)
        {

        }

        private void ToggleThemeTeachingTip2_Closed(TeachingTip sender, TeachingTipClosedEventArgs args)
        {
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

        private void TxtFIstName(TextBlock sender, TextChangedEventArgs e)
        {
            ProfilePicture_pp.DisplayName = sender.Text;
        }

        private void TxtLastName(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionProfesional(object sender, SelectionChangedEventArgs e)
        {

        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Professional professional = new Professional();
            professional.NameP = FirstName1_tbx.Text + LastName1_tbx.Text;
            professional.Profession.NameS = profession_cbx.Text;


            if (passwordBox == Confirm_passwordBox)
            {
                professional.PasswordP = passwordBox.Password;
            }
            else
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FechadeIngreso.Date = DateTime.Today;
        }

        private void TxtFIstName(object sender, TextChangedEventArgs e)
        {

        }
    }
}
