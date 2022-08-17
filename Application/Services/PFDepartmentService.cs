using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PFDepartmentService
    {
        public async Task<(List<PFDepartment>, List<string>)> GetComboboxChoices()
        {
            List<PFDepartment> objects = new List<PFDepartment>();
            List<string> objectStrings = new List<string>();

            objects = (List<PFDepartment>) await new PFDepartmentService().ListObjectAsync();

            foreach (var profession in objects)
            {
                objectStrings.Add(profession.NameDP);
            }

            return (objects, objectStrings);
        }

        public async Task<PFDepartment> GetObjectAsync(string id)
        {
            PFDepartment Department = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Department/{id}");
            if (response.IsSuccessStatusCode)
            {
                Department = await response.Content.ReadAsAsync<PFDepartment>();
            }

            return Department;
        }

        public async Task<IEnumerable<PFDepartment>> ListObjectAsync()
        {
            IEnumerable<PFDepartment> Department = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Department/");
            if (response.IsSuccessStatusCode)
            {
                Department = await response.Content.ReadAsAsync<IEnumerable<PFDepartment>>();
            }

            return Department;
        }

        public async Task<IEnumerable<PFDepartment>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFDepartment>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFDepartment> Department = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/Department/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                Department = await response.Content.ReadAsAsync<IEnumerable<PFDepartment>>();
            }

            return Department;
        }

        public async Task<IEnumerable<PFDepartment>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFDepartment> Departments = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Department/criteria");
            if (response.IsSuccessStatusCode)
            {
                Departments = await response.Content.ReadAsAsync<IEnumerable<PFDepartment>>();
            }

            return Departments;
        }

        public async Task<HttpStatusCode> Create(PFDepartment toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Department", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFDepartment toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Department/{toUpdateObject.IdDP}",
                    toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Department/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}