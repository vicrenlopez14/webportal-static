using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Services
{
    public class PfRankService : ICrudService<PFRank>
    {
            public async Task<PFRank> GetObjectAsync(string id)
        {
            PFRank rank = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Rank/{id}");
            if (response.IsSuccessStatusCode)
            {
                rank = await response.Content.ReadAsAsync<PFRank>();
            }

            return rank;
        }

        public async Task<IEnumerable<PFRank>> ListObjectAsync()
        {
            IEnumerable<PFRank> rank = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Rank/list");
            if (response.IsSuccessStatusCode)
            {
                rank = await response.Content.ReadAsAsync<IEnumerable<PFRank>>();
            }

            return rank;
        }

        public async Task<IEnumerable<PFRank>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFRank>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFRank> rank = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Rank/list");
            if (response.IsSuccessStatusCode)
            {
                rank = await response.Content.ReadAsAsync<IEnumerable<PFRank>>();
            }

            return rank;
        }

        public async Task<IEnumerable<PFRank>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFRank> ranks = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Rank/criteria");
            if (response.IsSuccessStatusCode)
            {
                ranks = await response.Content.ReadAsAsync<IEnumerable<PFRank>>();
            }

            return ranks;
        }

        public async Task<HttpStatusCode> Create(PFRank toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Rank", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFRank toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Rank/{toUpdateObject.IdR}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Rank/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}