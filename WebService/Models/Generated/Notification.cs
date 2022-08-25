using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models
{
    [Table("notification")]
    [Index("IdPj2", Name = "IdPJ2")]
    public partial class Notification
    {
        [Key]
        [StringLength(21)]
        public string IdN { get; set; } = null!;
        [StringLength(50)]
        public string? TitleN { get; set; }
        [StringLength(500)]
        public string? DescriptionN { get; set; }
        public DateOnly? DateTimeIssuedN { get; set; }
        public byte[]? PictureN { get; set; }
        [Column("IdPJ2")]
        [StringLength(21)]
        public string? IdPj2 { get; set; }
    }
}
