using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PFActivityService
    {
        public async Task<PFActivity> GetObjectAsync(string id)
        {
            PFActivity Activity = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Activity/{id}");
            if (response.IsSuccessStatusCode)
            {
                Activity = await response.Content.ReadAsAsync<PFActivity>();
            }

            return Activity;
        }

        public async Task<IEnumerable<PFActivity>> ListObjectAsync()
        {
            IEnumerable<PFActivity> Activity = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Activity/");
            if (response.IsSuccessStatusCode)
            {
                Activity = await response.Content.ReadAsAsync<IEnumerable<PFActivity>>();
            }

            return Activity;
        }

        public async Task<IEnumerable<PFActivity>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFActivity>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFActivity> Activity = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/Activity/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                Activity = await response.Content.ReadAsAsync<IEnumerable<PFActivity>>();
            }

            return Activity;
        }

        public async Task<IEnumerable<PFActivity>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFActivity> Activitys = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Activity/criteria");
            if (response.IsSuccessStatusCode)
            {
                Activitys = await response.Content.ReadAsAsync<IEnumerable<PFActivity>>();
            }

            return Activitys;
        }

        public async Task<HttpStatusCode> Create(PFActivity toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Activity", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFActivity toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Activity/{toUpdateObject.IdA}",
                    toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Activity/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}