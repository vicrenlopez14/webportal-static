using Domain.Models;
using ProFind.Lib.Global.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.Professional_Add
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Professional_Create : Page
    {
        public Professional_Create()
        {
            this.InitializeComponent();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionProfesional(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtLastName(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtFIstName(object sender, TextChangedEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            PFProfessional professional = new PFProfessional();
            professional.NameP = FirstName1_tbx.Text + LastName1_tbx.Text;

            PFProfessional professional1 = new PFProfessional();
            if (passwordBox == Confirm_passwordBox)
            {
                professional1.NameP = passwordBox.Password;
            }
            else
            {

            }


            var professionalsService = new PfProfessionalService();
            var resultado = await professionalsService.Login("usuario@gmail.com", "123456");

            if (resultado == System.Net.HttpStatusCode.OK)
            {

            }
            else
            {




            }
        }
    }
    }
