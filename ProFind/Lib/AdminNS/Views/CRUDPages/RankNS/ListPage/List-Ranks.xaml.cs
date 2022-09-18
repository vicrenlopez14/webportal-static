﻿using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Rank = ProFind.Lib.Global.Services.Rank;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.RankNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Ranks : Page
    {
        Rank Id1 = new Rank();
        public List_Ranks()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            int idNo = (int)Id1.IdR;
            await APIConnection.GetConnection.GetProjectstatusAsync(idNo);
        }
    }
}
