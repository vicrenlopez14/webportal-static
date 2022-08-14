using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Domain.Models
{
    public class PFProfession
    {
        [JsonConstructor]
        public PFProfession(int idPfs, string namePfs)
        {
            IdPFS = idPfs;
            NamePFS = namePfs;
        }

        [Column("IdPFS")] public int IdPFS { get; set; }

        [Column("NamePFS")] public string NamePFS { get; set; }
    }
}