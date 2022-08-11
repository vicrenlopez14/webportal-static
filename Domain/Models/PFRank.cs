using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PFRank
    {
        [JsonConstructor]
        public PFRank(string idR, string nameR)
        {
            IdR = idR;
            NameR = nameR;
        }

        [Column("IdR")] public string IdR { get; set; }
        [Column("NameR")] public string NameR { get; set; }
    }
}