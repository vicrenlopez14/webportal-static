using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProFind_WebService.Lib.Rank.Model;

public class PFRank
{
    [JsonConstructor]
    public PFRank(string? idR = null, string? nameR = null)
    {
        IdR = idR;
        NameR = nameR;
    }

    [Column("IdR")] public string? IdR { get; set; }
    [Column("NameR")] public string? NameR { get; set; }
}