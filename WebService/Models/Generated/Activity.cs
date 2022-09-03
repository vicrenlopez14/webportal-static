using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated;

[Table("activity")]
[Index("IdPj1", Name = "IdPJ1")]
[Index("IdT1", Name = "IdT1")]
public partial class Activity
{
    [Key]
    [StringLength(21)]
    public string IdA { get; set; } = null!;
    [StringLength(50)]
    public string? TitleA { get; set; }
    [StringLength(500)]
    public string? DescriptionA { get; set; }
    public DateOnly? ExpectedBeginA { get; set; }
    public DateOnly? ExpectedEndA { get; set; }
    public byte[]? PictureA { get; set; }
    [Column("IdPJ1")]
    [StringLength(21)]
    public string? IdPj1 { get; set; }
    [StringLength(21)]
    public string? IdT1 { get; set; }
}