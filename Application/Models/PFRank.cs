using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

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

        public PFRank()
        {
        }

        public async void FillFromId(string id)
        {
            var result = await new PfRankService().GetObjectAsync(id);

            IdR = result.IdR;
            NameR = result.NameR;
        }

        public string IdR { get; set; }
        public string NameR { get; set; }
    }
}