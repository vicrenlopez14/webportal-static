using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MySqlX.XDevAPI.Relational;

namespace ProFind_WebService.Lib.Curriculum.Model;

public class PFCurriculum
{
    [JsonConstructor]
    public PFCurriculum(string idCU=null, string? studiesCU = null, string? experiencesCU = null, int? yearsCU = default)
    {
        IdCU = idCU;
        StudiesCU = studiesCU;
        ExperiencesCU = experiencesCU;
        YearsCU = yearsCU;
    }

    public PFCurriculum() { }

    [Column("IdCU")] public string IdCU { get; set; }
    [Column("StudiesCU")] public string? StudiesCU { get; set; }
    [Column("ExperienceCU")] public string? ExperiencesCU { get; set; }
    [Column("YearsCU")] public int? YearsCU { get; set; }
}