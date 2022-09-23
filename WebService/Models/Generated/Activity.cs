using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("activity")]
    [Index("IdPj1", Name = "FK_Activity_Project")]
    public partial class Activity
    {
        [Key]
        [Column("IdAC")]
        [StringLength(21)]
        public string IdAc { get; set; } = null!;
        [Column("TitleAC")]
        [StringLength(50)]
        public string? TitleAc { get; set; }
        [Column("DescriptionAC")]
        [StringLength(500)]
        public string? DescriptionAc { get; set; }
        [Column("PictureAC")]
        public byte[]? PictureAc { get; set; }
        [Column("IdPJ1")]
        [StringLength(21)]
        public string? IdPj1 { get; set; }

        [ForeignKey("IdPj1")]
        [InverseProperty("Activities")]
        public virtual Project? IdPj1Navigation { get; set; }
    }
}
