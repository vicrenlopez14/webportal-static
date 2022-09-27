using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("pay")]
    [Index("IdPj4", Name = "FK_Pay_Project")]
    public partial class Pay
    {
        [Key]
        [Column("IdPY")]
        [StringLength(21)]
        public string IdPy { get; set; } = null!;
        [Column("PaidPY")]
        public bool? PaidPy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaidOn { get; set; }
        [Column("IdPJ4")]
        [StringLength(21)]
        public string? IdPj4 { get; set; }

        [ForeignKey("IdPj4")]
        [InverseProperty("Pays")]
        public virtual Project? IdPj4Navigation { get; set; }
    }
}
