using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Models.Generated
{
    [Table("profession")]
    public partial class Profession
    {
        [Key]
        [Column("IdS")]
        public int Ids { get; set; }
        [Column("NameS")]
        [StringLength(50)]
        public string? Names { get; set; }
    }
}
