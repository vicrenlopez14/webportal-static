using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class PFTag
    {
        public PFTag(string idT, string nameT, string IdPJ1)
        {
            IdT = idT;
            NameT = nameT;
            this.IdPJ1 = IdPJ1;
        }

        [Column("IdT")] public string IdT { get; set; }
        [Column("NameT")] public string NameT { get; set; }
        [Column("IdPJ1")] public string IdPJ1 { get; set; }
    }
}