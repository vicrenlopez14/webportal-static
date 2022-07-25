using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProFind_WebService.Lib.Client.Model;

public class PFClient
{
    [JsonConstructor]
    public PFClient(string idC, string? nameC = null, string? emailC = null, string? passwordC = null)
    {
        IdC = idC;
        NameC = nameC;
        EmailC = emailC;
        PasswordC = passwordC;
    }

    public PFClient () { }

    [Column("IdC")] public string IdC { get; set; }
    [Column("NameC")] public string? NameC { get; set; }
    [Column("EmailC")] public string? EmailC { get; set; }
    [Column("PasswordC")] public string? PasswordC { get; set; }
}