using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebService.Models.Generated
{
    [Table("supportticket")]
    [Index("IdA2", Name = "IdA2")]
    [Index("IdAct1", Name = "IdACT1")]
    [Index("IdC5", Name = "IdC5")]
    [Index("IdP5", Name = "IdP5")]
    [Index("IdPj4", Name = "IdPJ4")]
    [Index("IdPp2", Name = "IdPP2")]
    [Index("IdPpy1", Name = "IdPPY1")]
    public partial class Supportticket
    {
        [Key]
        [Column("IdST")]
        [StringLength(21)]
        public string IdSt { get; set; } = null!;
        [Column("TitleST")]
        [StringLength(50)]
        public string? TitleSt { get; set; }
        [Column("ContentST")]
        [StringLength(500)]
        public string? ContentSt { get; set; }
        [Column("ImageST")]
        public byte[]? ImageSt { get; set; }
        [Column("DocumentST")]
        public byte[]? DocumentSt { get; set; }
        [Column("LocationST")]
        [StringLength(100)]
        public string? LocationSt { get; set; }
        [Column("AudioST")]
        public byte[]? AudioSt { get; set; }
        [Column("DateTimeST")]
        public DateOnly? DateTimeSt { get; set; }
        [Column("TicketStatusST", TypeName = "enum('taken','pending','actiontaken')")]
        public string? TicketStatusSt { get; set; }
        [Column("SuggestedActionST", TypeName = "enum('checkproject','checkactivity','checkproposal','checkpayment','checkchat','closeticket')")]
        public string? SuggestedActionSt { get; set; }
        [Column("ResponseContentST")]
        [StringLength(500)]
        public string? ResponseContentSt { get; set; }
        [Column("ResponseImageST")]
        public byte[]? ResponseImageSt { get; set; }
        [Column("ResponseDocumentST")]
        public byte[]? ResponseDocumentSt { get; set; }
        [Column("ResponseLocationST")]
        [StringLength(100)]
        public string? ResponseLocationSt { get; set; }
        [Column("ResponseAudioST")]
        public byte[]? ResponseAudioSt { get; set; }
        [StringLength(21)]
        public string? IdP5 { get; set; }
        [StringLength(21)]
        public string? IdC5 { get; set; }
        [StringLength(21)]
        public string? IdA2 { get; set; }
        [Column("IdPJ4")]
        [StringLength(21)]
        public string? IdPj4 { get; set; }
        [Column("IdACT1")]
        [StringLength(21)]
        public string? IdAct1 { get; set; }
        [Column("IdPP2")]
        [StringLength(21)]
        public string? IdPp2 { get; set; }
        [Column("IdPPY1")]
        [StringLength(21)]
        public string? IdPpy1 { get; set; }
    }
}
