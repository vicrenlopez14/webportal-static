using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PfCurriculumService : ICrudService<PFCurriculum>
    {
           public async Task<PFCurriculum> GetObjectAsync(string id)
        {
            PFCurriculum curriculum = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Curriculum/{id}");
            if (response.IsSuccessStatusCode)
            {
                curriculum = await response.Content.ReadAsAsync<PFCurriculum>();
            }

            return curriculum;
        }

        public async Task<IEnumerable<PFCurriculum>> ListObjectAsync()
        {
            IEnumerable<PFCurriculum> curriculum = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Curriculum/list");
            if (response.IsSuccessStatusCode)
            {
                curriculum = await response.Content.ReadAsAsync<IEnumerable<PFCurriculum>>();
            }

            return curriculum;
        }

        public async Task<IEnumerable<PFCurriculum>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFCurriculum>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFCurriculum> curriculum = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Curriculum/list");
            if (response.IsSuccessStatusCode)
            {
                curriculum = await response.Content.ReadAsAsync<IEnumerable<PFCurriculum>>();
            }

            return curriculum;
        }

        public async Task<IEnumerable<PFCurriculum>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFCurriculum> curriculums = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Curriculum/criteria");
            if (response.IsSuccessStatusCode)
            {
                curriculums = await response.Content.ReadAsAsync<IEnumerable<PFCurriculum>>();
            }

            return curriculums;
        }

        public async Task<HttpStatusCode> Create(PFCurriculum toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Curriculum", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFCurriculum toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Curriculum/{toUpdateObject.IdCU}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Curriculum/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}