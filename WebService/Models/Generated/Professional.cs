using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models
{
    [Table("professional")]
    [Index("IdDp1", Name = "IdDP1")]
    [Index("IdPfs1", Name = "IdPFS1")]
    [Index("IdWdt1", Name = "IdWDT1")]
    public partial class Professional
    {
        [Key]
        [StringLength(21)]
        public string IdP { get; set; } = null!;
        [StringLength(50)]
        public string? NameP { get; set; }
        public DateOnly? DateBirthP { get; set; }
        [StringLength(21)]
        public string? EmailP { get; set; }
        [StringLength(64)]
        public string? PasswordP { get; set; }
        public bool? ActiveP { get; set; }
        public bool? SexP { get; set; }
        [Column("DUIP")]
        [StringLength(15)]
        public string? Duip { get; set; }
        [Column("AFPP")]
        [StringLength(50)]
        public string? Afpp { get; set; }
        [Column("ISSSP")]
        [StringLength(50)]
        public string? Isssp { get; set; }
        [StringLength(10)]
        public string? ZipCodeP { get; set; }
        public float? SalaryP { get; set; }
        public DateOnly? HiringDateP { get; set; }
        public byte[]? PictureP { get; set; }
        public byte[]? CurriculumP { get; set; }
        [Column("IdPFS1")]
        public int? IdPfs1 { get; set; }
        [Column("IdDP1")]
        public int? IdDp1 { get; set; }
        [Column("IdWDT1")]
        public int? IdWdt1 { get; set; }
    }
}
