using Application.Services;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFClient
    {
        [JsonConstructor]
        public PFClient(string idC, string nameC, string emailC, string passwordC)
        {
            IdC = idC;
            NameC = nameC;
            EmailC = emailC;
            PasswordC = passwordC;
        }

        public PFClient()
        {
        }

        public static PFClient Initialize(string id)
        {
            var infoTask = new PfClientService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdC { get; set; }
        public string NameC { get; set; }
        public string EmailC { get; set; }
        public string PasswordC { get; set; }
    }

    public class RegisterClient
    {
        [JsonConstructor]
        public RegisterClient(string nameC, string emailC, string passwordC)
        {
            NameC = nameC;
            EmailC = emailC;
            PasswordC = passwordC;
        }

        public string NameC { get; }
        public string EmailC { get; }
        public string PasswordC { get; }
    }
}