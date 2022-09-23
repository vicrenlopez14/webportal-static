using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Department = ProFind.Lib.Global.Services.Department;
using Profession = ProFind.Lib.Global.Services.Profession;
using Professional = ProFind.Lib.Global.Services.Professional;
using ProFind.Lib.AdminNS.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Editar_User : Page
    {


        Profession selectedProfession;
        Department selectedDepartment;

        Professional ToManipulateProfessional = new Professional();

        private string imageString;

        private byte[] curriculumBytes;

        private bool _isFirstAdmin;

        public Editar_User()
        {
            this.InitializeComponent();
            loadUsefulThings();
            AddEvents();
        }

        private void AddEvents()
        {
            FirstName1_tbx.OnEnterNextField();
            Afp.OnEnterNextField();
            Dui.OnEnterNextField();
            SeguroSocial.OnEnterNextField();
            CodigoPostal.OnEnterNextField();
            Email.OnEnterNextField();
            Salario.OnEnterNextField();
        }

        public async void loadUsefulThings()
        {

            profession_cbx.ItemsSource = await APIConnection.GetConnection.GetProfessionsAsync();
            profession_cbx.SelectedIndex = 0;

            departamento.ItemsSource = await APIConnection.GetConnection.GetDepartmentsAsync();
            departamento.SelectedIndex = 0;

        }
        private void position_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                ToManipulateProfessional = (Professional)e.Parameter;
                AutoComplete();
            }
            else
            {
                // Go back to professionals list
                // Error message dialog
                var dialog = new MessageDialog("Professional not found or  not valid.");
                await dialog.ShowAsync();

                // Back to profesionals list
                new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage.ReadPage));
            }
        }

        private void AutoComplete()
        {
            FirstName1_tbx.Text = ToManipulateProfessional.NameP;
            if (ToManipulateProfessional.IdPfs1 == 1) profession_cbx.SelectedIndex = 0;

            if (ToManipulateProfessional.IdPfs1 == 2) profession_cbx.SelectedIndex = 2;

            if (ToManipulateProfessional.IdPfs1 == 3) profession_cbx.SelectedIndex = 3;

            Afp.Text = ToManipulateProfessional.Afpp;
            SeguroSocial.Text = ToManipulateProfessional.Isssp;
            Dui.Text = ToManipulateProfessional.Duip;
            FechadeIngreso.Date = ToManipulateProfessional.HiringDateP;
            Email.Text = ToManipulateProfessional.EmailP;
            CodigoPostal.Text = ToManipulateProfessional.ZipCodeP;
            Salario.Text = ToManipulateProfessional.SalaryP.ToString();
            Nacimiento.Date = (DateTimeOffset)ToManipulateProfessional.DateBirthP;
            FirstName1_tbx.Text = ToManipulateProfessional.NameP;

        }

        private async void btnExaminar_Click_1(object sender, RoutedEventArgs e)
        {
            imageString = await (await PickFileHelper.PickImage()).ToBase64StringAsync();

            ProfilePicture_pp.ProfilePicture = await imageString.FromBase64String();
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

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            if (ToManipulateProfessional != null)
            {

                if(FirstName1_tbx.Text.Length <= 3)
                {
                    var dialog = new MessageDialog("The name must be valid");
                    await dialog.ShowAsync();
                    return;
                }
                if (!FieldsChecker.CheckEmail(Email.Text))
                {
                    var dialog = new MessageDialog("The name email be valid");
                    await dialog.ShowAsync();
                    return;
                }
                if (!FieldsChecker.CheckPassword(passwordBox.Password))
                {
                    var dialog = new MessageDialog("The password must be valid");
                    await dialog.ShowAsync();
                    return;
                }
                if (int.Parse(Salario.Text) <= 0)
                {
                    var dialog = new MessageDialog("The salary must be valid");
                    await dialog.ShowAsync();
                    return;
                }
                if (!FieldsChecker.CheckDateDown((DateTimeOffset)Nacimiento.Date))
                {
                    var dialog = new MessageDialog("The birth date must be valid");
                    await dialog.ShowAsync();
                    return;
                }
                if (!FieldsChecker.CheckDateUp((DateTimeOffset)FechadeIngreso.Date) && 
                    (DateTimeOffset)FechadeIngreso.Date != ToManipulateProfessional.HiringDateP)
                {
                    var dialog = new MessageDialog("The hiring date must be valid");
                    await dialog.ShowAsync();
                    return;
                }
                if(Confirm_passwordBox.Password != passwordBox.Password)
                {
                    var dialog = new MessageDialog("Password and confirmation password are not the same");
                    await dialog.ShowAsync();
                    return;
                }
                try
                {
                    var toCreateProfessions = new Professional { IdP = ToManipulateProfessional.IdP, NameP = FirstName1_tbx.Text, EmailP = Email.Text, Afpp = Afp.Text, Isssp = SeguroSocial.Text, Duip = Dui.Text, DateBirthP = (DateTimeOffset)Nacimiento.Date, SalaryP = int.Parse(Salario.Text), SexP = true, PasswordP = (string.IsNullOrEmpty(passwordBox.Password) ? ToManipulateProfessional.PasswordP : passwordBox.Password), ActiveP = Sexo.SelectedValue == "Male" ? true : false, PictureP = imageString, IdDp1 = (departamento.SelectedItem as Department).IdDp, IdPfs1 = (profession_cbx.SelectedItem as Profession).IdPfs, ZipCodeP = CodigoPostal.Text, HiringDateP = (DateTimeOffset)FechadeIngreso.Date };


                    await APIConnection.GetConnection.PutProfessionalAsync(ToManipulateProfessional.IdP, toCreateProfessions);

                    // Success message dialog
                    var dialog = new MessageDialog("The Professional has been updated successfully");
                    await dialog.ShowAsync();
                }
                catch (ProFindServicesException ex)
                {
                    if (ex.StatusCode == 201 || ex.StatusCode == 200 || ex.StatusCode == 204)
                    {
                        // Success message dialog
                        var dialog = new MessageDialog("The Professional has been updated successfully");
                        await dialog.ShowAsync();
                    }
                    else
                    {
                        // Error message dialog
                        var dialog = new MessageDialog("There was a problem updating the professional, pleasy try again later.");
                        //"There was a problem updating the professional, pleasy try again later."
                        await dialog.ShowAsync();
                    }
                }
                finally
                {
                    // Back to profesionals list
                    new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage.ReadPage));
                }
            }


        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void btnExaminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtFIstName(TextBlock sender, TextChangedEventArgs e)
        {

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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TxtFIstName(object sender, TextChangedEventArgs e)
        {

        }

        private async void btnCancelar_Click(object sender, RoutedEventArgs e)
        { 
            await APIConnection.GetConnection.DeleteProfessionalAsync(ToManipulateProfessional.IdP);
        }

        private void FirstName1_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }

        private void Afp_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyInts(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void SeguroSocial_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyInts(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void TextBox_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
        }

        private void CodigoPostal_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyInts(e)) e.Handled = true;
            else e.Handled = false;
        }

        private void Email_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.CheckEmail(Email.Text)) e.Handled = true;
            else e.Handled = false;
        }

        private void Salario_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyFloats(e, Salario.Text)) e.Handled = true;
            else e.Handled = false;
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ToManipulateProfessional != null)
            {
                try
                {
                    await APIConnection.GetConnection.DeleteProfessionalAsync(ToManipulateProfessional.IdP);

                    // Success message dialog
                    var dialog = new MessageDialog("The Professional has been deleted successfully");
                    await dialog.ShowAsync();
                }
                catch (ProFindServicesException ex)
                {
                    if (ex.StatusCode == 201 || ex.StatusCode == 200)
                    {
                        // Success message dialog
                        var dialog = new MessageDialog("The Professional has been deleted successfully");
                        await dialog.ShowAsync();
                    }
                    else
                    {
                        // Error message dialog
                        var dialog = new MessageDialog("There was a problem deleting the professional, pleasy try again later.");
                        await dialog.ShowAsync();
                    }
                }
                finally
                {
                    // Back to profesionals list
                    new InAppNavigationController().NavigateTo(typeof(Lib.AdminNS.Views.CRUDPages.ProfessionalNS.ListPage.ReadPage));
                }
            }
        }


        private void Nacimiento_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }

        private async void SelectCurriculum_Click_2(object sender, RoutedEventArgs e)
        {
            // Launch curriculum select dialog
            var result = await new Lib.AdminNS.Views.CRUDPages.CurriculumNS.CreatePage.CreateDialog().ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                // Set selected curriculum
                curriculumBytes = CurriculumNS.CreatePage.CreateDialog.curriculumBytes;

                CurriculumInformation.Text = "The curriculum has been uploaded.";
            }
            else
            {
                CurriculumInformation.Text = "No curriculum has been uploaded";
            }
        }

      
    }
}