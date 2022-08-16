using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

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

        public async void FillFromId(string id)
        {
            var result = await new PFProfessionService().GetObjectAsync(id);

            IdPFS = result.IdPFS;
            NamePFS = result.NamePFS;
        }


        public int IdPFS { get; set; }

        public string NamePFS { get; set; }
    }
}