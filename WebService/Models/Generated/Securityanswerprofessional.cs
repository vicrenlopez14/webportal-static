using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("securityanswerprofessionals")]
    [Index("IdP1", Name = "IdP1")]
    [Index("IdSq1", Name = "IdSQ1")]
    public partial class Securityanswerprofessional
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
        public string? IdP1 { get; set; }
    }
}
