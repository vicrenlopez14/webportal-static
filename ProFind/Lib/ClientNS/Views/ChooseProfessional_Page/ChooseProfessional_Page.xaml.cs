using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.ClientNS.Views.ChooseProfessional_Page
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ChooseProfessional_Page : Page
    {
        public ChooseProfessional_Page()
        {
            this.InitializeComponent();

            GetChooseProfessionalLis();
        }

        public async void GetChooseProfessionalLis()
        {
            var professional = new ProfessionalService();
            List<ProfessionService> chooseProfessionalList = new List<ProfessionService>(); 

            chooseProfessionalList = await professional.ListObjectAsync() as List<ProfessionService>;

            chooseProfessionalListView.ItemsSource = chooseProfessionalList;
        }
    }
}
