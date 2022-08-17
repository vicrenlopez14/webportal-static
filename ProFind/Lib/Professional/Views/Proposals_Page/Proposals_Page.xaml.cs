﻿using Application.Models;
using Application.Services;
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

namespace ProFind.Lib.Professional.Views.Proposals_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Proposals_Page : Page
    {
        public Proposals_Page()
        {
            this.InitializeComponent();
        }
        public async void GetProjectsList()

        {

            var projectService = new PfProjectService();

            List<PFProject> NotifiProfesionaList = new List<PFProject>();

            NotifiProfesionaList = await projectService.ListObjectAsync() as List<PFProject>;

            ProposalsProfesionalListView.ItemsSource = NotifiProfesionaList;
        }
    }
}
