using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

namespace Application.Models
{
    public class PFTag
    {
        [JsonConstructor]
        public PFTag(string idT, string nameT, string IdPJ1)
        {
            IdT = idT;
            NameT = nameT;
            this.IdPJ1 = IdPJ1;
        }

        public PFTag()
        {
        }

      
        public async void FillFromId(string id)
        {
            var result = await new PFTagService().GetObjectAsync(id);

            IdT = result.IdT;
            NameT = result.NameT;
            IdPJ1 = result.IdPJ1;
        }

        public string IdT { get; set; }
        public string NameT { get; set; }
        public string IdPJ1 { get; set; }
    }
}