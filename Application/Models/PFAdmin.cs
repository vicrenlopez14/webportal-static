using Application.Services;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFAdmin

    {
        [JsonConstructor]
        public PFAdmin(string idA, string nameA, string emailA, string telA,
            string passwordA, string idR1, byte[] pictureA)
        {
            IdA = idA;
            NameA = nameA;
            EmailA = emailA;
            TelA = telA;
            PasswordA = passwordA;
            IdR1 = idR1;
            PictureA = pictureA;
        }

        public PFAdmin(string nameA, string emailA, string telA,
            string passwordA, string idR1, byte[] pictureA)
        {
            NameA = nameA;
            EmailA = emailA;
            TelA = telA;
            PasswordA = passwordA;
            IdR1 = idR1;
            PictureA = pictureA;
        }

        public async void FillFromId(string id)
        {
            var result = await new PFAdminService().GetObjectAsync(id);

            IdA = result.IdA;
            NameA = result.NameA;
            EmailA = result.EmailA;
            TelA = result.TelA;
            PasswordA = result.PasswordA;
            IdR1 = result.IdR1;
            if (!string.IsNullOrEmpty(IdR1))
                Rank.FillFromId(IdR1);
            PictureA = result.PictureA;
        }


        public PFAdmin()
        {
        }

        public string IdA { get; set; }
        public string NameA { get; set; }
        public string EmailA { get; set; }
        public string TelA { get; set; }
        public string PasswordA { get; set; }

        public byte[] PictureA { get; set; }

        public string IdR1 { get; set; }


        public PFRank Rank;
    }

    public class LoginAdmin
    {
        [JsonConstructor]
        public LoginAdmin(string emailA, string passwordA)
        {
            EmailA = emailA;
            PasswordA = passwordA;
        }

        public LoginAdmin()
        {
        }

        public string EmailA { get; }
        public string PasswordA { get; }
    }
}