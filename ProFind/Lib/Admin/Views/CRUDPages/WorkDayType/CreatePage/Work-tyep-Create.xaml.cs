﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Admin.Views.CRUDPages.WorkDayType.CreatePage
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Work_tyep_Create : Page
    {
        private PFWorkDayType newObject = new PFWorkDayType();
        public Work_tyep_Create()
        {
            this.InitializeComponent();
        }

        private async void Create_btn_Click(object sender, RoutedEventArgs e)
        {

            var result = await new PFWorkDayTypeService().Create(newObject);
        }

        private void Name_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            newObject.NameWDT = Name_tb.Text;
        }
    }
}
