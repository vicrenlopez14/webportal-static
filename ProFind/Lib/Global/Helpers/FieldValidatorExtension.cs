using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace ProFind.Lib.Global.Helpers
{
    public static class TextBoxValidatorExtension
    {
        // Verify a List of TextBoxes are not empty
        public static List<TextBox> EmptyTextBoxes(this List<TextBox> textBoxes)
        {
            var emptyTextBoxes = new List<TextBox>();

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    emptyTextBoxes.Add(textBox);
                }
            }

            return emptyTextBoxes;
        }

        public static async void ShowAlertsForEmptyTextBoxes(this List<TextBox> textBoxes)
        {
            var emptyTextBoxes = textBoxes.EmptyTextBoxes();

            // Foreach over emptyTextBoxes
            foreach (var textBox in emptyTextBoxes)
            {
                var dialog = new MessageDialog("The field is empty");
                await dialog.ShowAsync();
            }
        }

        public static bool IsValid(this TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text);
        }

        public static bool IsValidEmail(this TextBox textBlock)
        {

            var email = textBlock.Text;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(this TextBox textBlock)
        {
            var phone = textBlock.Text;
            return phone.Length == 8;
        }

        public static bool IsValidPassword(this TextBox textBlock)
        {
            var password = textBlock.Text;
            return password.Length >= 8;
        }

        public static bool IsValidName(this TextBox textBlock)
        {
            var name = textBlock.Text;
            return name.Length >= 3;
        }

        public static bool IsValidNumber(this TextBox textBlock)
        {
            var number = textBlock.Text;
            return number.Length >= 1;
        }

        public static bool IsValidDate(this TextBox textBlock)
        {
            var date = textBlock.Text;
            return date.Length >= 1;
        }

        public static bool IsValidAddress(this TextBox textBlock)
        {
            var address = textBlock.Text;
            return address.Length >= 1;
        }

        public static bool IsValidCity(this TextBox textBlock)
        {
            var city = textBlock.Text;
            return city.Length >= 1;
        }

        public static bool IsValidState(this TextBox textBlock)
        {
            var state = textBlock.Text;
            return state.Length >= 1;
        }

        public static bool IsValidZipCode(this TextBox textBlock)
        {
            var zipCode = textBlock.Text;
            return zipCode.Length >= 1;
        }

        public static bool IsValidCountry(this TextBox textBlock)
        {
            var country = textBlock.Text;
            return country.Length >= 1;
        }

        public static bool IsValidLatitude(this TextBox textBlock)
        {
            var latitude = textBlock.Text;
            return latitude.Length >= 1;
        }

        public static bool IsValidLongitude(this TextBox textBlock)
        {
            var longitude = textBlock.Text;
            return longitude.Length >= 1;
        }

        public static bool IsValidPicture(this TextBox textBlock)
        {
            var picture = textBlock.Text;
            return picture.Length >= 1;
        }

    }

    public static class NumberBoxValidatorExtension
    {

        public static bool IsValidPhone(this NumberBox textBlock)
        {
            var phone = textBlock.Value;
            return phone == 8;
        }


    }

}
