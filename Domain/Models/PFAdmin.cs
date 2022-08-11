using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
public class PFAdmin

{
    [JsonConstructor]
        public PFAdmin(string idA, string nameA, string emailA, string telA,
            string passwordA, string idR1)
    {
        IdA = idA;
        NameA = nameA;
        EmailA = emailA; 
        TelA = telA;
        PasswordA = passwordA;
        IdR1 = idR1;
    }

        public PFAdmin()
        {
        }

    [Column("IdA")] public string IdA { get; set; }
        [Column("NameA")] public string NameA { get; set; }
        [Column("EmailA")] public string EmailA { get; set; }
        [Column("TelA")] public string TelA { get; set; }
        [Column("PasswordA")] public string PasswordA { get; set; }
        [Column("IdR1")] public string IdR1 { get; set; }
    }
}