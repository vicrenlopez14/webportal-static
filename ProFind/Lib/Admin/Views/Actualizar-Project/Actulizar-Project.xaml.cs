﻿using Application.Models;
using Application.Services;
using ProFind.Lib.Admin.Controllers;
using ProFind.Lib.Professional.Controllers;
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

namespace ProFind.Lib.Admin.Actualizar_Project
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Actulizar_Project : Page
    {
        private bool _isFirstAdmin;

        public bool SucessfulCreation_tt { get; private set; }

        public Actulizar_Project()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _isFirstAdmin = (bool)e.Parameter;

        }

        private async void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            PFProject project = new PFProject();
            var profession = new PFProfessional();



            project.ResponsibleProfessional = profession;

            project.TitlePJ = TitlePJ.Text;
            project.DescriptionPJ = DescriptionPJ.Text;
            project.TotalPricePJ = float.Parse(TotalPricePJ.Text);
            project.Status = Inactivo.IsChecked == true ? PFProjectStatus.Active : PFProjectStatus.Inactive;



            var respuesta = await new PfProjectService().Update(project);

            if (respuesta == HttpStatusCode.OK)
            {
                SucessfulCreation_tt = true;
                new clientNavigationController().GoBack();

                if (_isFirstAdmin)
                {
                    new AdminNavigationController().NavigateTo(typeof(Lib.Professional.Views.InitPage.InitPage));
                }
            }
        }
    }
}