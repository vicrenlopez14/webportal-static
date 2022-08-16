using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

namespace Application.Models
{
    public class PFDepartment
    {
        [JsonConstructor]
        public PFDepartment(string idDp, string nameDp)
        {
            IdDP = idDp;
            NameDP = nameDp;
        }

        public PFDepartment()
        {
        }

      

        public async void FillFromId(string id)
        {
            var result = await new PFDepartmentService().GetObjectAsync(id);

            IdDP = result.IdDP;
            NameDP = result.NameDP;
        }


        public string IdDP { get; set; }

        public string NameDP { get; set; }
    }
}