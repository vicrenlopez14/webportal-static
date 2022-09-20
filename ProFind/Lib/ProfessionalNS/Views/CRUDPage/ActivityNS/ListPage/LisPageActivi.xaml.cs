﻿using ProFind.Lib.Global.Controllers;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class LisPageActivi : Page
    {
        Activity Id;
        public LisPageActivi()
        {
            this.InitializeComponent();
            GetProjectsList();
        }
        public async void GetProjectsList()
        {
            Activities_lw.ItemsSource = await APIConnection.GetConnection.GetActivityAsync( Id.IdA);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.UpdatePage.UpdatePageActivi));
        }

        private void Activities_lw_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.CreatePage.CreatePageActivi));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ProfessionalNS.Views.CRUDPage.ActivityNS.SearchPage.SearchPage));
        }
    }
}
