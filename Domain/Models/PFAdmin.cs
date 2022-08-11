using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProFind_WebService.Lib.Admin.Model;

public class PFAdmin
{
    [JsonConstructor]
    public PFAdmin(string idA = null, string? nameA = null, string? emailA = null, string? telA = null,
        string? passwordA = null, string? idR1 = null)
    {
        IdA = idA;
        NameA = nameA;
        EmailA = emailA; 
        TelA = telA;
        PasswordA = passwordA;
        IdR1 = idR1;
    }

    public PFAdmin() { }

    [Column("IdA")] public string IdA { get; set; }
    [Column("NameA")] public string? NameA { get; set; }
    [Column("EmailA")] public string? EmailA { get; set; }
    [Column("TelA")] public string? TelA { get; set; }
    [Column("PasswordA")] public string? PasswordA { get; set; }
    [Column("IdR1")] public string? IdR1 { get; set; }
}