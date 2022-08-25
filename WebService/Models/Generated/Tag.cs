﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models
{
    [Table("tag")]
    [Index("IdPj1", Name = "IdPJ1")]
    public partial class Tag
    {
        [Key]
        [StringLength(21)]
        public string IdT { get; set; } = null!;
        [StringLength(50)]
        public string? NameT { get; set; }
        [Column("IdPJ1")]
        [StringLength(21)]
        public string? IdPj1 { get; set; }
    }
}