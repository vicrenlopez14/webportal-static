using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PFTagService : ICrudService<PFTag>
    {
        public async Task<PFTag> GetObjectAsync(string id)
        {
            PFTag tag = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Tag/{id}");
            if (response.IsSuccessStatusCode)
            {
                tag = await response.Content.ReadAsAsync<PFTag>();
            }

            return tag;
        }

        public async Task<IEnumerable<PFTag>> ListObjectAsync()
        {
            IEnumerable<PFTag> Tag = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Tag/");
            if (response.IsSuccessStatusCode)
            {
                Tag = await response.Content.ReadAsAsync<IEnumerable<PFTag>>();
            }

            return Tag;
        }

        public async Task<IEnumerable<PFTag>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFTag>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFTag> Tag = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/Tag/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                Tag = await response.Content.ReadAsAsync<IEnumerable<PFTag>>();
            }

            return Tag;
        }

        public async Task<IEnumerable<PFTag>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFTag> Tags = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Tag/criteria");
            if (response.IsSuccessStatusCode)
            {
                Tags = await response.Content.ReadAsAsync<IEnumerable<PFTag>>();
            }

            return Tags;
        }

        public async Task<HttpStatusCode> Create(PFTag toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Tag", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFTag toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Tag/{toUpdateObject.IdT}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Tag/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}