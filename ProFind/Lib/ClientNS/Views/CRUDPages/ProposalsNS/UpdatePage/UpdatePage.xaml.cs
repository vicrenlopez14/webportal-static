﻿using ProFind.Lib.AdminNS.Controllers;
using ProFind.Lib.ClientNS.Controllers;
using ProFind.Lib.Global.Controllers;
using ProFind.Lib.Global.Helpers;
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

namespace ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UpdatePage : Page
    {
        private string imageString;

        Proposal IPp;
        public UpdatePage()
        {
            this.InitializeComponent();
            AddEvents();
        }
        private void AddEvents()
        {
            Title_tb.OnEnterNextField();
            Description_tb.OnEnterNextField();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                IPp = (Proposal)e.Parameter;
            }
        }

        private void LoadData()
        {
            Title_tb.Text = IPp.TitlePp;
            Description_tb.Text = IPp.DescriptionPp;
            Theend.Date = (DateTimeOffset)IPp.SuggestedEnd;
        }

        private async void PictureSelection_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                var file = await PickFileHelper.PickImage();

                if (file != null)
                {
                    SelectedPicture_tbk.Text = file.Name;
                    imageString = await file.ToBase64StringAsync();

                    //SelectedPicture_pp.ProfilePicture = imageString.ToBitmapImage();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                PictureSelection_btn.IsChecked = false;
            }
        }

        private void Title_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Description_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        private void Title_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void Description_tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private async void Create_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                var loggedClient = LoggedClientStore.LoggedClient;
                var toCreateAdmin = new Proposal { TitlePp = Title_tb.Text, DescriptionPp = Description_tb.Text, SuggestedEnd = (DateTimeOffset)Theend.Date, PicturePp = imageString, IdPp = IPp.IdPp, IdC3 = loggedClient.IdC };




                 await APIConnection.GetConnection.PutProposalAsync(IPp.IdPp, toCreateAdmin);
                new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.ListPage.ListPAge));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        private async void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            await APIConnection.GetConnection.DeleteProposalAsync(IPp.IdPp);
            new GlobalNavigationController().NavigateTo(typeof(ProFind.Lib.ClientNS.Views.CRUDPages.ProposalsNS.ListPage.ListPAge));
        }

        private void Create_btn_Click_12(object sender, RoutedEventArgs e)
        {
            new InAppNavigationController().GoBack();
        }
    }
}
