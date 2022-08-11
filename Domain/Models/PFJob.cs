using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PFJob
    {
        [JsonConstructor]
        public PFJob(string idJ, string nameJ)
        {
            IdJ = idJ;
            NameJ = nameJ;
        }

        public PFJob() { }

        [Column("IdJ")] public string IdJ { get; set; }
        [Column("NameJ")] public string NameJ { get; set; }
    }
}