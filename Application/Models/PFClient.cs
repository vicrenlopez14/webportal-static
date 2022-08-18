using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Models
{
    public class PFClient
    {
        [JsonConstructor]
        public PFClient(string idC, string nameC, string emailC, string passwordC, byte[] pictureC)
        {
            IdC = idC;
            NameC = nameC;
            EmailC = emailC;
            PasswordC = passwordC;
            PictureC = pictureC;
        }

        public PFClient()
        {
        }


        public async void FillFromId(string id)
        {
            var result = await new PfClientService().GetObjectAsync(id);

            IdC = result.IdC;
            NameC = result.NameC;
            EmailC = result.EmailC;
            PasswordC = result.PasswordC;
            PictureC = result.PictureC;
        }


        public string IdC { get; set; }
        public string NameC { get; set; }
        public string EmailC { get; set; }
        public string PasswordC { get; set; }

        public byte[] PictureC { get; set; }

        public Task<List<PFClient>> ListObjectAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class LoginClient
    {
        [JsonConstructor]
        public LoginClient(string emailC, string passwordC)
        {
            EmailC = emailC;
            PasswordC = passwordC;
        }

        public LoginClient()
        {
        }

        public string EmailC { get; }
        public string PasswordC { get; }
    }

    public class RegisterClient
    {
        [JsonConstructor]
        public RegisterClient(string nameC, string emailC, string passwordC, byte[] pictureC)
        {
            NameC = nameC;
            EmailC = emailC;
            PasswordC = passwordC;
            PictureC = pictureC;
        }

        public string NameC { get; }
        public string EmailC { get; }
        public string PasswordC { get; }

        public byte[] PictureC { get; set; }
    }
}