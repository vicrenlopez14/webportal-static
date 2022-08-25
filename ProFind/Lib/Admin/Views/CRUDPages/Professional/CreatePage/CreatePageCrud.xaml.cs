using Application.Models;
using Application.Services;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.CRUDPages.Professional.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        private List<PFProfession> professions = new List<PFProfession>();
        private List<string> professionStrings = new List<string>();

        private List<PFDepartment> departments = new List<PFDepartment>();
        private List<string> departmentsStrings = new List<string>();

        private List<PFWorkDayType> workdaytypes = new List<PFWorkDayType>();
        private List<string> workdaytypestrings = new List<string>();

        byte[] pictureBytes;

        private bool _isFirstAdmin;


        public BlankPage2()
        {
            this.InitializeComponent();
            loadUsefulThings();
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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
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

    }
}
