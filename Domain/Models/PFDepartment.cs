using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Domain.Models
{
    public class PFDepartment
    {
        [JsonConstructor]
        public PFDepartment(string idDp, string nameDp)
        {
            IdDP = idDp;
            NameDP = nameDp;
        }

        [Column("IdDP")] public string IdDP { get; set; }

        [Column("NameDP")] public string NameDP { get; set; }
    }
}