using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProFind_WebService.Lib.Job.Model;

public class PFJob
{
    [JsonConstructor]
    public PFJob(string idJ=null, string? nameJ=null)
    {
        IdJ = idJ;
        NameJ = nameJ;
    }

    public PFJob() { }

    [Column("IdJ")] public string IdJ { get; set; }
    [Column("NameJ")] public string? NameJ { get; set; }
}