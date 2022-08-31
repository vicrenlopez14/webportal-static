using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("project")]
    [Index("IdC1", Name = "IdC1")]
    [Index("IdP1", Name = "IdP1")]
    [Index("IdPs1", Name = "IdPS1")]
    public partial class Project
    {
        [Key]
        [Column("IdPJ")]
        [StringLength(21)]
        public string IdPj { get; set; } = null!;
        [Column("TitlePJ")]
        [StringLength(50)]
        public string? TitlePj { get; set; }
        [Column("DescriptionPJ")]
        [StringLength(50)]
        public string? DescriptionPj { get; set; }
        [Column("PicturePJ")]
        public byte[]? PicturePj { get; set; }
        [Column("TotalPricePJ")]
        public float? TotalPricePj { get; set; }
        [Column("IdPS1")]
        public int? IdPs1 { get; set; }
        [StringLength(21)]
        public string? IdP1 { get; set; }
        [StringLength(21)]
        public string? IdC1 { get; set; }
    }
}
