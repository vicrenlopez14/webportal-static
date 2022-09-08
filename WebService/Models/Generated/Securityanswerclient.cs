using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("securityanswerclients")]
    [Index("IdC1", Name = "IdC1")]
    [Index("IdSq1", Name = "IdSQ1")]
    public partial class Securityanswerclient
    {
        [Key]
        [Column("IdSA")]
        [StringLength(21)]
        public string IdSa { get; set; } = null!;
        [Column("AnswerSA")]
        [StringLength(50)]
        public string? AnswerSa { get; set; }
        [Column("IdSQ1")]
        [StringLength(21)]
        public string? IdSq1 { get; set; }
        [StringLength(21)]
        public string? IdC1 { get; set; }
    }
}
