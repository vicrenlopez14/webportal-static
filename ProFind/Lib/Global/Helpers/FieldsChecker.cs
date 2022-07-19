using System.Text.RegularExpressions;

namespace UWP_ProFind.Lib.Global.Helpers
{
    public class FieldsChecker
    {
        public static bool CheckEmail(string email)
        {
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9]+)*(.[a-z]{2,4})$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPassword(string pass)
        {
            return (pass.Length >= 5);
        }
        public static bool CheckPassword(string pass, string confirm)
        {
            return (pass.Length >= 5 && pass == confirm);
        }
    }

}
