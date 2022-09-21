using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Profession = ProFind.Lib.Global.Services.Profession;
using ProFind.Lib.Global.Controllers;
using System.Collections.Generic;
using ProFind.Lib.AdminNS.Controllers;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionNS.ListPage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class List_Page : Page
    {
        public List_Page()
        {
            this.InitializeComponent();
            InitializeData();
        }
        private async void InitializeData()
        {
            ProfessionalsListView.ItemsSource = await APIConnection.GetConnection.GetProfessionsAsync() as List<Profession>;
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionNS.CreatePage.Profession_Create));

        }

        private void Add_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            new InAppNavigationController().NavigateTo(typeof(ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionNS.UpdatePage.Update_Profesion));

        }
    }
}
