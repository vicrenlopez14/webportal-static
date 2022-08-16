using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PfProjectService : ICrudService<PFProject>
    {
           public async Task<PFProject> GetObjectAsync(string id)
        {
            PFProject project = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Project/{id}");
            if (response.IsSuccessStatusCode)
            {
                project = await response.Content.ReadAsAsync<PFProject>();
            }

            return project;
        }

        public async Task<IEnumerable<PFProject>> ListObjectAsync()
        {
            IEnumerable<PFProject> project = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Project/");
            if (response.IsSuccessStatusCode)
            {
                project = await response.Content.ReadAsAsync<IEnumerable<PFProject>>();
            }

            return project;
        }

        public async Task<IEnumerable<PFProject>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFProject>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFProject> project = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Project/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                project = await response.Content.ReadAsAsync<IEnumerable<PFProject>>();
            }

            return project;
        }

        public async Task<IEnumerable<PFProject>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFProject> projects = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Project/criteria");
            if (response.IsSuccessStatusCode)
            {
                projects = await response.Content.ReadAsAsync<IEnumerable<PFProject>>();
            }

            return projects;
        }

        public async Task<HttpStatusCode> Create(PFProject toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Project", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFProject toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Project/{toUpdateObject.IdPJ}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Project/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}