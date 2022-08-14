using Application.Services;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFRank
    {
        [JsonConstructor]
        public PFRank(string idR, string nameR)
        {
            IdR = idR;
            NameR = nameR;
        }

        public static PFRank Initialize(string id)
        {
            var infoTask = new PfRankService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdR { get; set; }
        public string NameR { get; set; }
    }
}