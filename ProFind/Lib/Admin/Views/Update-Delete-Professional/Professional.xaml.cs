using Application.Models;
using Application.Services;
using Microsoft.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Update-Delete-Professional;
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ProfessionalInformationAddition : Page
    {
        private List<PFProfession> professions = new List<PFProfession>();
        private List<string> professionStrings = new List<string>();

        private List<PFDepartment> departments = new List<PFDepartment>();
        private List<string> departmentsStrings = new List<string>();

        private List<PFWorkDayType> workdaytypes = new List<PFWorkDayType>();
        private List<string> workdaytypestrings = new List<string>();

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
            (professions, professionStrings) = await new PFProfessionService().GetComboboxChoices();
            profession_cbx.ItemsSource = null;
            profession_cbx.ItemsSource = professionStrings;

            // Departments
            (departments, departmentsStrings) = await new PFDepartmentService().GetComboboxChoices();
            departamento.ItemsSource = null;
            departamento.ItemsSource = departmentsStrings;

            // Work-day types
            (workdaytypes, workdaytypestrings) = await new PFWorkDayTypeService().GetComboboxChoices();
            Jornada.ItemsSource = null;
            Jornada.ItemsSource = workdaytypestrings;
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
            PFProfessional professional = new PFProfessional();
            professional.NameP = FirstName1_tbx.Text + " " + LastName1_tbx.Text;

            // Nested objects
            var profession = new PFProfession();
            profession = professions.Where(x => x.NamePFS == profession_cbx.SelectedValue).First();

            professional.Department = new PFDepartment();
            professional.Department = departments.Where(x => x.NameDP == departamento.SelectedValue).First();

            professional.WorkDayType = new PFWorkDayType();
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

            var respuesta = await new PFProfessionalService().Create(professional);
            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt.IsOpen = true;

                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
                }
            }

        }

        private void ToggleThemeTeachingTip2_ActionButtonClick(TeachingTip sender, object args)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
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
            PFProfessional professional = new PFProfessional();
            professional.NameP = FirstName1_tbx.Text + LastName1_tbx.Text;
            professional.Profession.NamePFS = profession_cbx.Text;


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
