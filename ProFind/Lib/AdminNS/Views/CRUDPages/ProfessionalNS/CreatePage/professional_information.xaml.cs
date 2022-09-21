﻿using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;
using ProFind.Lib.Global.Helpers;
using ProFind.Lib.Global.Services;
using Department = ProFind.Lib.Global.Services.Department;
using Profession = ProFind.Lib.Global.Services.Profession;
using Professional = ProFind.Lib.Global.Services.Professional;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionalNS.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ProfessionalInformationAddition : Page
    {
        Profession pro = new Profession();
        Department depa;

        Professional toManipulate = new Professional();

        private List<Department> departments = new List<Department>();
        private byte[] imageBytes;


        private byte[] curriculo;

     
        public ProfessionalInformationAddition()
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
            position.OnEnterNextField();
            CodigoPostal.OnEnterNextField();
            Email.OnEnterNextField();
            Salario.OnEnterNextField();

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

            try
            {

                byte[] da = toManipulate.PictureP = await (await PickFileHelper.PickImage()).ToByteArrayAsync();

                var toCreateProfessions = new Professional { IdP = "", NameP = FirstName1_tbx.Text, EmailP = Email.Text, Afpp = Afp.Text, Isssp = SeguroSocial.Text, Duip = Dui.Text, DateBirthP = Nacimiento.Date, SalaryP = int.Parse(Salario.Text), SexP = true, PasswordP = passwordBox.Password, ActiveP = Sexo.SelectedValue == "Male" ? true : false, PictureP = imageBytes, IdDp1 = int.Parse(departamento.Text), IdPfs1 = int.Parse(profession_cbx.Text), ZipCodeP = CodigoPostal.Text, HiringDateP = FechadeIngreso.Date };



                var result = await APIConnection.GetConnection.PostProfessionalAsync(toCreateProfessions);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
          
        }

        private void ToggleThemeTeachingTip2_CloseButtonClick(TeachingTip sender, object args)
        {

        }

        private void ToggleThemeTeachingTip2_Closed(TeachingTip sender, TeachingTipClosedEventArgs args)
        {
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

        private void FirstName1_tbx_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;

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

        private void position_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (FieldsChecker.OnlyLetters(e)) e.Handled = true;
            else e.Handled = false;

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
            
        }

        private void Nacimiento_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }
    }
}
