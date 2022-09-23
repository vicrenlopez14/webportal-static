using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProFind.Lib.Global.Services;
using Profession = ProFind.Lib.Global.Services.Profession;
using ProFind.Lib.Global.Helpers;
using Windows.UI.Popups;
using System;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.AdminNS.Views.CRUDPages.ProfessionNS.UpdatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Update_Profesion : Page
    {
        Profession pro = new Profession();
        public Update_Profesion()
        {
            this.InitializeComponent();
        }

        private async void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!FieldsChecker.CheckName(Name_tb.Text))
            {
                var dialog = new MessageDialog("The name must be valid");
                await dialog.ShowAsync();
                return;
            }
            int idNo = (int)pro.IdPfs;
            var toUpdateProfession = new Profession { NamePfs = Name_tb.Text };
            await APIConnection.GetConnection.PutProfessionAsync(idNo, toUpdateProfession);
        }

        private async void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            int idNo = (int)pro.IdPfs;

            await APIConnection.GetConnection.DeleteProfessionAsync(idNo);
            
        }

        private void Name_tb_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }
    }
}
