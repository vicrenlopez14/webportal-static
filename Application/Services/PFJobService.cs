using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Services
{
    public class PfJobService : ICrudService<PFJob>
    {
            public async Task<PFJob> GetObjectAsync(string id)
        {
            PFJob job = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Job/{id}");
            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<PFJob>();
            }

            return job;
        }

        public async Task<IEnumerable<PFJob>> ListObjectAsync()
        {
            IEnumerable<PFJob> job = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Job/list");
            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<IEnumerable<PFJob>>();
            }

            return job;
        }

        public async Task<IEnumerable<PFJob>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFJob>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFJob> job = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Job/list");
            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<IEnumerable<PFJob>>();
            }

            return job;
        }

        public async Task<IEnumerable<PFJob>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFJob> jobs = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Job/criteria");
            if (response.IsSuccessStatusCode)
            {
                jobs = await response.Content.ReadAsAsync<IEnumerable<PFJob>>();
            }

            return jobs;
        }

        public async Task<HttpStatusCode> Create(PFJob toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Job", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFJob toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Job/{toUpdateObject.IdJ}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Job/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}