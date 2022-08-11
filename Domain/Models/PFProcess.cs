using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProFind_WebService.Lib.Process.Model;

public class PFProcess
{
    [JsonConstructor]
    public PFProcess(string idPR, string? titlePR = null, string? descriptionPR = null, DateTime? beginDatePR = default,
        string? idTag = null, DateTime? endDatePR = default)
    {
        IdPR = idPR;
        TitlePR = titlePR;
        DescriptionPR = descriptionPR;
        BeginDatePR = beginDatePR;
        IdTag = idTag;
        EndDatePR = endDatePR;
    }

    public PFProcess() { }

    [Column("IdPR")] public string IdPR { get; set; }
    [Column("TitlePR")] public string? TitlePR { get; set; }
    [Column("DescriptionPR")] public string? DescriptionPR { get; set; }
    [Column("BeginDatePR")] public DateTime? BeginDatePR { get; set; }
    [Column("IdT1")] public string? IdTag { get; set; }
    [Column("EnddatePR")] public DateTime? EndDatePR { get; set; }
}