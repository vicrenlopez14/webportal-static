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

namespace ProFind.Lib.Admin.Views.Professional_CRUD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfessionalCreate : Page
    {
        public ProfessionalCreate()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            DateTimeOffset dateBirth = dpBirth.Date;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string curriculum = txtCurriculum.Text;
            string job = txtJob.Text;


        }
    }
}
