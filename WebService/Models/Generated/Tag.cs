using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("tag")]
    public partial class Tag
    {
        [Key]
        [StringLength(21)]
        public string IdT { get; set; } = null!;
        [StringLength(50)]
        public string? NameT { get; set; }
        [StringLength(6)]
        public string? ColorT { get; set; }
    }
}
