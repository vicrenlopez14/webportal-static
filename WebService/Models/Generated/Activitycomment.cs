using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("activitycomment")]
    [Index("IdA1", Name = "IdA1")]
    [Index("IdC5", Name = "IdC5")]
    [Index("IdP5", Name = "IdP5")]
    public partial class Activitycomment
    {
        [Key]
        [Column("IdAC")]
        [StringLength(21)]
        public string IdAc { get; set; } = null!;
        [Column("CommentAC")]
        [StringLength(500)]
        public string? CommentAc { get; set; }
        [Column("DateAC")]
        public DateOnly? DateAc { get; set; }
        [Column("AskToCheckChatAC")]
        public bool? AskToCheckChatAc { get; set; }
        [StringLength(21)]
        public string? IdA1 { get; set; }
        [StringLength(21)]
        public string? IdP5 { get; set; }
        [StringLength(21)]
        public string? IdC5 { get; set; }
    }
}
