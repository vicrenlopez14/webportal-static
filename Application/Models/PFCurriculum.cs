using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

namespace Application.Models
{
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


        public async void FillFromId(string id)
        {
            var result = await new PfCurriculumService().GetObjectAsync(id);

            IdCU = result.IdCU;
            StudiesCU = result.StudiesCU;
            ExperiencesCU = result.ExperiencesCU;
            YearsCU = result.YearsCU;
        }

        public string IdCU { get; set; }
        public string StudiesCU { get; set; }
        public string ExperiencesCU { get; set; }
        public int YearsCU { get; set; }
    }
}