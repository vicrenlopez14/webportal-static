using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Models
{
    [Table("profession")]
    public partial class Profession
    {
        [Key]
        [Column("IdPFS")]
        public int IdPfs { get; set; }
        [Column("NamePFS")]
        [StringLength(50)]
        public string? NamePfs { get; set; }
    }
}
