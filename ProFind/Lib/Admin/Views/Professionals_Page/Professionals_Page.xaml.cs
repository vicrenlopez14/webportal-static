using Domain.Models;
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

namespace ProFind.Lib.Admin.Views.Professionals_Page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Professionals_Page : Page
    {
        public Professionals_Page()
        {
            this.InitializeComponent();

            List<PFProfessional> professionalsList = new List<PFProfessional> {
               new PFProfessional { IdP = "1", NameP = "Juan", DateBirthP = DateTime.Now, EmailP = "" },
               new PFProfessional { IdP = "2", NameP = "Pedro", DateBirthP = DateTime.Now, EmailP = "" },
               new PFProfessional { IdP = "3", NameP = "María", DateBirthP = DateTime.Now, EmailP = "" },
               new PFProfessional { IdP = "4", NameP = "Arnoldo", DateBirthP = DateTime.Now, EmailP = "" },
               new PFProfessional { IdP = "5", NameP = "Alessandro", DateBirthP = DateTime.Now, EmailP = "" },
            };

            ProfessionalsList.ItemsSource = professionalsList;
        }
    }
}
