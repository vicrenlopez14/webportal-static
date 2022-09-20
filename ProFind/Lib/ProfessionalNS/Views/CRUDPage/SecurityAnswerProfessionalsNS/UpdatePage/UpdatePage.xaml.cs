﻿using ProFind.Lib.Global.Services;
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

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.SecurityAnswerProfessionalsNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        public UpdatePage()
        {
            this.InitializeComponent();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var toUpdapteAnswerProfessional = new Securityanswerprofessional(Answer1_tb.Text, Answer2_tb.Text);

            await APIConnection.GetConnection.PostSecurityanswerprofessionalAsync(id.IdSa, toUpdapteAnswerProfessional);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
