using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Models
{
    [Table("workdaytype")]
    public partial class Workdaytype
    {
        [Key]
        [Column("IdWDT")]
        public int IdWdt { get; set; }
        [Column("NameWDT")]
        [StringLength(25)]
        public string? NameWdt { get; set; }
    }
}
