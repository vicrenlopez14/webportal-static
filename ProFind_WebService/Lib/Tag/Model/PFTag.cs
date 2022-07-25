using System.ComponentModel.DataAnnotations.Schema;

namespace ProFind_WebService.Lib.Tag.Model;

public class PFTag
{
    public PFTag(string idT, string? nameT = null, string? IdPJ1 = null)
    {
        IdT = idT;
        NameT = nameT;
        IdPJ1 = IdPJ1;
    }

    [Column("IdT")] public string IdT { get; set; }
    [Column("NameT")] public string? NameT { get; set; }
    [Column("IdPJ1")] public string? IdPJ1 { get; set; }
}