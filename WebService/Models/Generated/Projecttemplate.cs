using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("projecttemplate")]
    [Index("IdP1", Name = "IdP1")]
    public partial class Projecttemplate
    {
        [Key]
        [Column("IdPT")]
        [StringLength(21)]
        public string IdPt { get; set; } = null!;
        [Column("TitlePT")]
        [StringLength(50)]
        public string? TitlePt { get; set; }
        [Column("DescriptionPT")]
        [StringLength(50)]
        public string? DescriptionPt { get; set; }
        [Column("PicturePT")]
        public byte[]? PicturePt { get; set; }
        [Column("TotalPricePT")]
        public float? TotalPricePt { get; set; }
        [Column("SaveTagsPT")]
        public bool? SaveTagsPt { get; set; }
        [Column("SaveProjectPaysPT")]
        public bool? SaveProjectPaysPt { get; set; }
        [StringLength(21)]
        public string? IdP1 { get; set; }
    }
}
