namespace Application.Services
{
    internal class LoginProfessional
    {
        private string email;
        private string password;

        public LoginProfessional(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}