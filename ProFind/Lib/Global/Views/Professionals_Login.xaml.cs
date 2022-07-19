using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_ProFind.Lib.Global.Controllers;
using UWP_ProFind.Lib.Global.Helpers;
using UWP_ProFind.Lib.Professional.Views.Main_Page;
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

namespace UWP_ProFind.Lib.Global.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Professionals_Login : Page
    {
        public Professionals_Login()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mail_tb.Text == "" || pass_tb.Password == "")
            {
                warning_tb.Text = "Please do not leave empty fields";
                return;
            }

            if (!FieldsChecker.CheckEmail(mail_tb.Text))
            {
                warning_tb.Text = "Please enter a valid email";
                return;
            }
            if (!FieldsChecker.CheckPassword(pass_tb.Password))

            {
                warning_tb.Text = "The password must be 5 characters long at least";
                return;
            }

            if (logInIt(mail_tb.Text, pass_tb.Password))
            {
                new GlobalNavigationController().NavigateTo(typeof(Main_Page_Professional));
            }
            else
            {
                warning_tb.Text = "Wrong email or password.";
            }
        }

        public bool logInIt(string email, string password)
        {
            Connection connectionObj = new Connection();

            var query = $"SELECT Password_P FROM Profesional WHERE Email_P = '{email}';";

            try
            {
                var results = Connection.ExecuteQueryInDatabase(query);

                Console.WriteLine(results.Rows[0][0].ToString());
                if (results.Rows[0][0].ToString() == password)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
