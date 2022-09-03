using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated;

[Table("client")]
public partial class Client
{
    [Key]
    [StringLength(21)]
    public string IdC { get; set; } = null!;
    [StringLength(50)]
    public string? NameC { get; set; }
    [StringLength(50)]
    public string? EmailC { get; set; }
    [StringLength(64)]
    public string? PasswordC { get; set; }
    public byte[]? PictureC { get; set; }
}