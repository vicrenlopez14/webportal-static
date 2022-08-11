using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ProFind_WebService.Lib.Curriculum.Model;
using ProFind_WebService.Lib.Job.Model;

namespace ProFind_WebService.Lib.Professional.Model;

public class PFProfessional
{
    [JsonConstructor]
    public PFProfessional(string idP, string? nameP, DateTime? dateBirthP, string? emailP, string? passwordP,
        string? idCU1, string? idJ1)
    {
        IdP = idP;
        NameP = nameP;
        DateBirthP = dateBirthP;
        EmailP = emailP;
        PasswordP = passwordP;
        IdCU1 = idCU1;
        IdJ1 = idJ1;
    }

    public PFProfessional () { }

    [Column("IdP")] public string IdP { get; set; }
    [Column("NameP")] public string? NameP { get; set; }
    [Column("DateBirthP")] public DateTime? DateBirthP { get; set; }
    [Column("EmailP")] public string? EmailP { get; set; }
    [Column("PasswordP")] public string? PasswordP { get; set; }
    [Column("IdCU1")] public string? IdCU1 { get; set; }
    [Column("IdJ1")] public string? IdJ1 { get; set; }
}