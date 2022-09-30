﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("proposal")]
    [Index("IdC3", Name = "FK_Proposal_Client")]
    [Index("IdP3", Name = "FK_Proposal_Professional")]
    public partial class Proposal
    {
        [Key]
        [Column("IdPP")]
        [StringLength(21)]
        public string IdPp { get; set; } = null!;
        [Column("TitlePP")]
        [StringLength(50)]
        public string? TitlePp { get; set; }
        [Column("DescriptionPP")]
        [StringLength(500)]
        public string? DescriptionPp { get; set; }
        [Column("PicturePP")]
        public string? PicturePp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SuggestedStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SuggestedEnd { get; set; }
        public bool? Seen { get; set; }
        public bool? Accepted { get; set; }
        [StringLength(21)]
        public string? IdP3 { get; set; }
        [StringLength(21)]
        public string? IdC3 { get; set; }

        [ForeignKey("IdC3")]
        [InverseProperty("Proposals")]
        public virtual Client? IdC3Navigation { get; set; }
        [ForeignKey("IdP3")]
        [InverseProperty("Proposals")]
        public virtual Professional? IdP3Navigation { get; set; }
    }
}
