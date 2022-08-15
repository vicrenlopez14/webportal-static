using Application.Services;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFWorkDayType
    {
        [JsonConstructor]
        public PFWorkDayType(string idWdt, string nameWdt)
        {
            IdWDT = idWdt;
            NameWDT = nameWdt;
        }

        public PFWorkDayType()
        {
        }

        public static PFWorkDayType Initialize(string id)
        {
            var infoTask = new PFWorkDayTypeService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdWDT { get; set; }
        public string NameWDT { get; set; }
    }
}