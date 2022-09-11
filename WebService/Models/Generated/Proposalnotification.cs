using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("proposalnotification")]
    [Index("IdC4", Name = "IdC4")]
    [Index("IdP4", Name = "IdP4")]
    [Index("IdPp1", Name = "IdPP1")]
    public partial class Proposalnotification
    {
        [Key]
        [Column("IdPN")]
        [StringLength(21)]
        public string IdPn { get; set; } = null!;
        [Column("ContentPN")]
        [StringLength(500)]
        public string? ContentPn { get; set; }
        [Column("ImagePN")]
        public byte[]? ImagePn { get; set; }
        [Column("ActionPN", TypeName = "enum('chat','resend','support','checktoapprove')")]
        public string? ActionPn { get; set; }
        [Column("IdPP1")]
        [StringLength(21)]
        public string? IdPp1 { get; set; }
        [StringLength(21)]
        public string? IdP4 { get; set; }
        [StringLength(21)]
        public string? IdC4 { get; set; }
    }
}
