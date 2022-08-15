using Application.Services;
using Newtonsoft.Json;

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

        public static PFDepartment Initialize(string id)
        {
            var infoTask = new PFDepartmentService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdDP { get; set; }

        public string NameDP { get; set; }
    }
}