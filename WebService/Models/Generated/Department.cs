using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models
{
    [Table("department")]
    public partial class Department
    {
        [Key]
        [Column("IdDP")]
        public int IdDp { get; set; }
        [Column("NameDP")]
        [StringLength(30)]
        public string? NameDp { get; set; }
    }
}
