using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PFWorkDayTypeService : ICrudService<PFWorkDayType>
    {
        public async Task<(List<PFWorkDayType>, List<string>)> GetComboboxChoices()
        {
            List<PFWorkDayType> objects = new List<PFWorkDayType>();
            List<string> objectStrings = new List<string>();

            objects = (List<PFWorkDayType>) await new PFWorkDayTypeService().ListObjectAsync();

            foreach (var profession in objects)
            {
                objectStrings.Add(profession.NameWDT);
            }

            return (objects, objectStrings);
        }

        public async Task<PFWorkDayType> GetObjectAsync(string id)
        {
            PFWorkDayType WorkDayType = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/WorkDayType/{id}");
            if (response.IsSuccessStatusCode)
            {
                WorkDayType = await response.Content.ReadAsAsync<PFWorkDayType>();
            }

            return WorkDayType;
        }

        public async Task<IEnumerable<PFWorkDayType>> ListObjectAsync()
        {
            IEnumerable<PFWorkDayType> WorkDayType = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/WorkDayType/");
            if (response.IsSuccessStatusCode)
            {
                WorkDayType = await response.Content.ReadAsAsync<IEnumerable<PFWorkDayType>>();
            }

            return WorkDayType;
        }

        public async Task<IEnumerable<PFWorkDayType>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFWorkDayType>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFWorkDayType> WorkDayType = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/WorkDayType/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                WorkDayType = await response.Content.ReadAsAsync<IEnumerable<PFWorkDayType>>();
            }

            return WorkDayType;
        }

        public async Task<IEnumerable<PFWorkDayType>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFWorkDayType> WorkDayTypes = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/WorkDayType/criteria");
            if (response.IsSuccessStatusCode)
            {
                WorkDayTypes = await response.Content.ReadAsAsync<IEnumerable<PFWorkDayType>>();
            }

            return WorkDayTypes;
        }

        public async Task<HttpStatusCode> Create(PFWorkDayType toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/WorkDayType", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFWorkDayType toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/WorkDayType/{toUpdateObject.IdWDT}",
                    toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/WorkDayType/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}