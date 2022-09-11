using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("securityansweradmins")]
    [Index("IdA1", Name = "IdA1")]
    [Index("IdSq1", Name = "IdSQ1")]
    public partial class Securityansweradmin
    {
        [Key]
        [Column("IdSA")]
        [StringLength(21)]
        public string IdSa { get; set; } = null!;
        [Column("AnswerSA")]
        [StringLength(50)]
        public string? AnswerSa { get; set; }
        [Column("IdSQ1")]
        [StringLength(21)]
        public string? IdSq1 { get; set; }
        [StringLength(21)]
        public string? IdA1 { get; set; }
    }
}
