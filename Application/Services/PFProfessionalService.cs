using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PfProfessionalService : ICrudService<PFProfessional>
    {
        public async Task<HttpStatusCode> Login(string email, string password)
        {
            var values = new Dictionary<string, string>
            {
                {"email", email},
                {"password", password}
            };

            var content = new FormUrlEncodedContent(values);

            var response = await WebAPIConnection.GetConnection.PostAsync($"api/Professional/login", content);

            return response.StatusCode;
        }

        public async Task<PFProfessional> GetObjectAsync(string id)
        {
            PFProfessional professional = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Professional/{id}");
            if (response.IsSuccessStatusCode)
            {
                professional = await response.Content.ReadAsAsync<PFProfessional>();
            }

            return professional;
        }

        public async Task<IEnumerable<PFProfessional>> ListObjectAsync()
        {
            IEnumerable<PFProfessional> professional = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Professional/");
            if (response.IsSuccessStatusCode)
            {
                professional = await response.Content.ReadAsAsync<IEnumerable<PFProfessional>>();
            }

            return professional;
        }

        public async Task<IEnumerable<PFProfessional>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFProfessional>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFProfessional> professional = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/Professional/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                professional = await response.Content.ReadAsAsync<IEnumerable<PFProfessional>>();
            }

            return professional;
        }

        public async Task<IEnumerable<PFProfessional>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFProfessional> professionals = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Professional/criteria");
            if (response.IsSuccessStatusCode)
            {
                professionals = await response.Content.ReadAsAsync<IEnumerable<PFProfessional>>();
            }

            return professionals;
        }

        public async Task<HttpStatusCode> Create(PFProfessional toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Professional", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFProfessional toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Professional/{toUpdateObject.IdP}",
                    toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Professional/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}