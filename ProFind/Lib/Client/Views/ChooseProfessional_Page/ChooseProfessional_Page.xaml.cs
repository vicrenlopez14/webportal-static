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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProFind.Lib.Client.Views.ChooseProfesional_Page
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
            var professional = new PFProjectService();
            List<PFProfessionService> chooseProfessionalList = new List<PFProfessionService>(); 

            chooseProfessionalList = await professional.ListObjectAsync() as List<PFProfessionService>;

            chooseProfessionalListView.ItemsSource = chooseProfessionalList;
        }
    }
}
