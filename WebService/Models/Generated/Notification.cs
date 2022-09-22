using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("notification")]
    [Index("IdC3", Name = "FK_Notification_Client")]
    public partial class Notification
    {
        [Key]
        [StringLength(21)]
        public string IdN { get; set; } = null!;
        [StringLength(50)]
        public string? TitleN { get; set; }
        [StringLength(500)]
        public string? DescriptionN { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeIssuedN { get; set; }
        public byte[]? PictureN { get; set; }
        [StringLength(21)]
        public string? IdC3 { get; set; }

        [ForeignKey("IdC3")]
        [InverseProperty("Notifications")]
        public virtual Client? IdC3Navigation { get; set; }
    }
}
