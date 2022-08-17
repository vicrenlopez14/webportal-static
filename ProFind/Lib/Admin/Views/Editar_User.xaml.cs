using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Global.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Editar_User : Page
    {
        private bool _isFirstAdmin;

        public bool SucessfulCreation_tt { get; private set; }

        public Editar_User()
        {
            this.InitializeComponent();
        }

        private void TxtNumEmpleado(object sender, TextChangedEventArgs e)
        {

        }

        private void TxFIstName(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtLastName(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEmail(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPuesto(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMetodoDePago(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtSalario(object sender, TextChangedEventArgs e)
        {

        }

        private void txtJornada(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _isFirstAdmin = (bool)e.Parameter;

        }

        private async void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            PFProfessional professional = new PFProfessional();
            var profession = new PFProfession();

            

            professional.Profession = profession;
            professional.NameP = Fistname.Text + LastName.Text;
            professional.EmailP = Email.Text;
            professional.SalaryP = Salario.Text;
            professional.PasswordP = Confirm_passwordBox.Password;


            var respuesta = await new PFProjectService().Update(professional);
            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new clientNavigationController().GoBack();

                if (_isFirstAdmin)
                {
                    new GlobalNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
                }
            }
        }
    }
}
