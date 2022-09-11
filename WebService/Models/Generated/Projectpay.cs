using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("projectpay")]
    [Index("IdC3", Name = "IdC3")]
    [Index("IdP3", Name = "IdP3")]
    [Index("IdPj3", Name = "IdPJ3")]
    public partial class Projectpay
    {
        [Key]
        [Column("IdPPY")]
        [StringLength(21)]
        public string IdPpy { get; set; } = null!;
        [Column("PercentagePPY")]
        public float? PercentagePpy { get; set; }
        [Column("ConceptPPY")]
        [StringLength(500)]
        public string? ConceptPpy { get; set; }
        [Column("AmountPPY")]
        public float? AmountPpy { get; set; }
        [Column("CurrencyPPY")]
        [StringLength(3)]
        public string? CurrencyPpy { get; set; }
        [Column("HasLimitDatePPY")]
        public bool? HasLimitDatePpy { get; set; }
        [Column("LimitDatePPY")]
        public DateOnly? LimitDatePpy { get; set; }
        [Column("DefaultAmountPPY")]
        public float? DefaultAmountPpy { get; set; }
        [Column("PayStatusPPY", TypeName = "enum('pending','done','rejected')")]
        public string? PayStatusPpy { get; set; }
        [StringLength(21)]
        public string? IdP3 { get; set; }
        [StringLength(21)]
        public string? IdC3 { get; set; }
        [Column("IdPJ3")]
        [StringLength(21)]
        public string? IdPj3 { get; set; }
    }
}
