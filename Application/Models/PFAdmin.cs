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

        public PFAdmin()
        {
        }

        public string IdA { get; set; }
        public string NameA { get; set; }
        public string EmailA { get; set; }
        public string TelA { get; set; }
        public string PasswordA { get; set; }
        
        public byte[] PictureA { get; set; }

        private string _idR1;

        public string IdR1
        {
            get => _idR1;
            set
            {
                _idR1 = value;
                Rank = PFRank.Initialize(_idR1);
            }
        }

        public PFRank Rank;
    }
}