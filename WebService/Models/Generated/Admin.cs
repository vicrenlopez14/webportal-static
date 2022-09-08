using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("admin")]
    [Index("IdR1", Name = "IdR1")]
    public partial class Admin
    {
        [Key]
        [StringLength(21)]
        public string IdA { get; set; } = null!;
        [StringLength(50)]
        public string? NameA { get; set; }
        [StringLength(50)]
        public string? EmailA { get; set; }
        [StringLength(15)]
        public string? TelA { get; set; }
        [StringLength(64)]
        public string? PasswordA { get; set; }
        public byte[]? PictureA { get; set; }
        [StringLength(21)]
        public string? IdR1 { get; set; }
    }
}
