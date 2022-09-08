using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("message")]
    [Index("IdC4", Name = "IdC4")]
    [Index("IdP4", Name = "IdP4")]
    public partial class Message
    {
        [Key]
        [StringLength(21)]
        public string IdM { get; set; } = null!;
        [StringLength(500)]
        public string? ContentM { get; set; }
        public byte[]? ImageM { get; set; }
        public byte[]? DocumentM { get; set; }
        [StringLength(100)]
        public string? LocationM { get; set; }
        public byte[]? AudioM { get; set; }
        public DateOnly? DateTimeM { get; set; }
        [StringLength(21)]
        public string? IdP4 { get; set; }
        [StringLength(21)]
        public string? IdC4 { get; set; }
    }
}
