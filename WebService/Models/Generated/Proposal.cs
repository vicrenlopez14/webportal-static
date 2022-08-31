using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("proposal")]
    [Index("IdC3", Name = "IdC3")]
    [Index("IdP3", Name = "IdP3")]
    public partial class Proposal
    {
        [Key]
        [Column("IdPP")]
        [StringLength(21)]
        public string IdPp { get; set; } = null!;
        [Column("TitlePP")]
        [StringLength(50)]
        public string? TitlePp { get; set; }
        [Column("DescriptionPP")]
        [StringLength(500)]
        public string? DescriptionPp { get; set; }
        [Column("PicturePP")]
        public byte[]? PicturePp { get; set; }
        public DateOnly? SuggestedStart { get; set; }
        public DateOnly? SuggestedEnd { get; set; }
        [StringLength(21)]
        public string? IdP3 { get; set; }
        [StringLength(21)]
        public string? IdC3 { get; set; }
    }
}
