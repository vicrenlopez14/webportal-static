using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Models
{
    [Table("projectstatus")]
    public partial class Projectstatus
    {
        [Key]
        [Column("IdPS")]
        public int IdPs { get; set; }
        [Column("NamePS")]
        [StringLength(20)]
        public string? NamePs { get; set; }
    }
}
