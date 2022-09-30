﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("client")]
    public partial class Client
    {
        public Client()
        {
            Changepasswordcodes = new HashSet<Changepasswordcode>();
            Projects = new HashSet<Project>();
            Proposals = new HashSet<Proposal>();
        }

        [Key]
        [StringLength(21)]
        public string IdC { get; set; } = null!;
        [StringLength(50)]
        public string? NameC { get; set; }
        [StringLength(255)]
        public string? EmailC { get; set; }
        [StringLength(64)]
        public string? PasswordC { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RegistrationDateC { get; set; }
        public string? PictureC { get; set; }

        [InverseProperty("IdC1Navigation")]
        public virtual ICollection<Changepasswordcode> Changepasswordcodes { get; set; }
        [InverseProperty("IdC1Navigation")]
        public virtual ICollection<Project> Projects { get; set; }
        [InverseProperty("IdC3Navigation")]
        public virtual ICollection<Proposal> Proposals { get; set; }
    }
}
