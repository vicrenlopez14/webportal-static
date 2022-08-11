using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


public class PFCurriculum
{
    [JsonConstructor]
    public PFCurriculum(string idCU, string studiesCU, string experiencesCU, int yearsCU)
    {
        IdCU = idCU;
        StudiesCU = studiesCU;
        ExperiencesCU = experiencesCU;
        YearsCU = yearsCU;
    }

    public PFCurriculum()
    {
    }

    [Column("IdCU")] public string IdCU { get; set; }
    [Column("StudiesCU")] public string StudiesCU { get; set; }
    [Column("ExperienceCU")] public string ExperiencesCU { get; set; }
    [Column("YearsCU")] public int YearsCU { get; set; }
}