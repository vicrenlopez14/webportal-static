using Application.Services;
using Newtonsoft.Json;

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

        public static PFTag Initialize(string id)
        {
            var infoTask = new PFTagService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdT { get; set; }
        public string NameT { get; set; }
        public string IdPJ1 { get; set; }
    }
}