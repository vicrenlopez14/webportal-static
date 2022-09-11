using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("projectstatus")]
    [Index("IdPj3", Name = "IdPJ3")]
    public partial class Projectstatus
    {
        [Key]
        [Column("IdPS")]
        [StringLength(21)]
        public string IdPs { get; set; } = null!;
        [Column("NamePS")]
        [StringLength(20)]
        public string? NamePs { get; set; }
        [Column("DescriptionPS")]
        [StringLength(150)]
        public string? DescriptionPs { get; set; }
        [Column("ColorPS")]
        [StringLength(6)]
        public string? ColorPs { get; set; }
        [Column("IdPJ3")]
        [StringLength(21)]
        public string? IdPj3 { get; set; }
    }
}
