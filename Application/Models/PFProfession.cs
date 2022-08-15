using Application.Services;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFProfession
    {
        [JsonConstructor]
        public PFProfession(int idPfs, string namePfs)
        {
            IdPFS = idPfs;
            NamePFS = namePfs;
        }

        public PFProfession()
        {
        }

        public static PFProfession Initialize(string id)
        {
            var infoTask = new PFProfessionService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public int IdPFS { get; set; }

        public string NamePFS { get; set; }
    }
}