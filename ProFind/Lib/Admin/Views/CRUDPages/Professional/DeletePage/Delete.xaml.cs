using Application.Models;
using Application.Services;
using ProFind.Lib.Global.Helpers;
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


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.CRUDPages.Professional.DeletePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Delete : Page
    {
        PFProfessional toManipulate = new PFProfessional();
        byte[] pictureBytes;


        public Delete()
        {
            this.InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            await new PFProfessionalService().Delete(toManipulate.IdP);
        }

        private async void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            FirstName1_tbx.Text = toManipulate.NameP;
            LastName1_tbx.Text = toManipulate.NameP;
            passwordBox.Password = toManipulate.PasswordP;
            Afp.Text = toManipulate.AFPP;
            Dui.Text = toManipulate.DUIP;
            SeguroSocial.Text = toManipulate.ISSSP;
            Email.Text = toManipulate.EmailP;
            Salario.Text = toManipulate.SalaryP;
            await new PFProfessionalService().Update(toManipulate);
        }

        private async void btnExaminar_Click(object sender, RoutedEventArgs e)
        {
            toManipulate.PictureP = await(await PickFileHelper.PickImage()).ToByteArrayAsync();
        }

    }
}
