using Microsoft.UI.Xaml.Controls;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.Professional_CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePageProfessional : Page
    {
        Professional toManipulate = new Professional();

        private List<Profession> professions = new List<Profession>();
        private List<string> professionStrings = new List<string>();

        private List<Department> departments = new List<Department>();
        private List<string> departmentsStrings = new List<string>();

        private List<WorkDayType> workdaytypes = new List<WorkDayType>();
        private List<string> workdaytypestrings = new List<string>();

        byte[] pictureBytes;

        private bool _isFirstAdmin;
        public CreatePageProfessional()
        {
            this.InitializeComponent();
            loadUsefulThings();

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is bool)
            {
                _isFirstAdmin = (bool)e.Parameter;
            }

            base.OnNavigatedTo(e);
            if (e.Parameter is Professional)
            {
                toManipulate = (Professional)e.Parameter;
                await loadUsefulThings();
                FillFields(toManipulate);
                ManipulationMode();
                return;
            }

            CreationMode();
        }

        private void FillFields(Professional incomingProfessional)
        {
            FirstName1_tbx.Text = incomingProfessional.NameP;
            ProfilePicture_pp.ProfilePicture = incomingProfessional.PictureP.ToBitmapImage();
            profession_cbx.Text = incomingProfessional.Profession.NameS;
            profession_cbx.SelectedIndex = 0;
            Afp.Text = incomingProfessional.AFPP;
            Dui.Text = incomingProfessional.DUIP;
            SeguroSocial.Text = incomingProfessional.ISSSP;
            Nacimiento.Date = incomingProfessional.DateBirthP;
            departamento.Text = incomingProfessional.Department.NameDP;
            CodigoPostal.Text = incomingProfessional.ZipCodeP;
            Email.Text = incomingProfessional.EmailP;
            Sexo.SelectedIndex = incomingProfessional.SexP ? 0 : 1;
            Salario.Text = incomingProfessional.SalaryP;
            Jornada.Text = incomingProfessional.WorkDayType.NameWDT;
            FechadeIngreso.Date = incomingProfessional.HiringDateP;
        }

        private void CreationMode()
        {
            Create_btn.Visibility = Visibility.Visible;
            Update_btn.Visibility = Visibility.Collapsed;
            Reset_btn.Visibility = Visibility.Collapsed;
            Delete_btn.Visibility = Visibility.Collapsed;
            Confirm_passwordBox.Visibility = Visibility.Visible;
        }

        private void ManipulationMode()
        {
            Create_btn.Visibility = Visibility.Collapsed;
            Update_btn.Visibility = Visibility.Visible;
            Reset_btn.Visibility = Visibility.Visible;
            Delete_btn.Visibility = Visibility.Visible;
            Confirm_passwordBox.Visibility = Visibility.Collapsed;
        }

        public async Task<bool> loadUsefulThings()
        {
            // Professions
            (professions, professionStrings) = await new ProfessionService().GetComboboxChoices();
            profession_cbx.ItemsSource = null;
            profession_cbx.ItemsSource = professionStrings;
            profession_cbx.SelectedIndex = 0;

            // Departments
            (departments, departmentsStrings) = await new DepartmentService().GetComboboxChoices();
            departamento.ItemsSource = null;
            departamento.ItemsSource = departmentsStrings;
            departamento.SelectedIndex = 0;

            // Work-day types
            (workdaytypes, workdaytypestrings) = await new WorkDayTypeService().GetComboboxChoices();
            Jornada.ItemsSource = null;
            Jornada.ItemsSource = workdaytypestrings;
            Jornada.SelectedIndex = 0;

            return true;
        }



        private void Selection_Sexo(object sender, SelectionChangedEventArgs e)
        {
            toManipulate.SexP = Sexo.SelectedIndex == 0;
        }

        private void TxtNumEmpleado(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtNum_SeguroSocial(object sender, TextChangedEventArgs e)
        {
            toManipulate.ISSSP = SeguroSocial.Text;
        }

        private void TxtPuestoDeTrabajo(object sender, TextChangedEventArgs e)
        {
        }

        private void Selection_Departamento(object sender, SelectionChangedEventArgs e)
        {
            toManipulate.Department = departments[departamento.SelectedIndex];
            toManipulate.IdDP1 = toManipulate.Department.IdDP;
        }

        private void TxtDui(object sender, TextChangedEventArgs e)
        {
            toManipulate.DUIP = Dui.Text;
        }

        private void TxtCodigo_Postal(object sender, TextChangedEventArgs e)
        {
            toManipulate.ZipCodeP = Dui.Text;
        }

        private void TxtEmail(object sender, TextChangedEventArgs e)
        {
            toManipulate.EmailP = Email.Text;
        }

        private void txtMetodoDePago(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtSalario(object sender, TextChangedEventArgs e)
        {
            toManipulate.SalaryP = Salario.Text;
        }

        private void Selection_Tipo_Jornada(object sender, SelectionChangedEventArgs e)
        {
            toManipulate.WorkDayType = workdaytypes[Jornada.SelectedIndex];
        }

        private void TxtAFP(object sender, TextChangedEventArgs e)
        {
            toManipulate.AFPP = Afp.Text;
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            Professional professional = new Professional();
            professional.NameP = FirstName1_tbx.Text;

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
            toManipulate.PictureP = pictureBytes;
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
            if (professions.Count > 0 && profession_cbx.SelectedIndex> -1)
                toManipulate.Profession = professions[profession_cbx.SelectedIndex];

            toManipulate.IdS1 = profession_cbx.SelectedIndex.ToString();

        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            toManipulate.PasswordP = passwordBox.Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Professional professional = new Professional();
            professional.NameP = FirstName1_tbx.Text;
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
            toManipulate.NameP = FirstName1_tbx.Text;

        }

        private void Nacimiento_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            toManipulate.DateBirthP = Nacimiento.Date;
        }


        private void FechadeIngreso_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            toManipulate.HiringDateP = FechadeIngreso.Date;

        }
    }
}
