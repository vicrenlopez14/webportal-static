using Application.Services;
using Newtonsoft.Json;

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

        public static PFCurriculum Initialize(string id)
        {
            var infoTask = new PfCurriculumService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdCU { get; set; }
        public string StudiesCU { get; set; }
        public string ExperiencesCU { get; set; }
        public int YearsCU { get; set; }
    }
}