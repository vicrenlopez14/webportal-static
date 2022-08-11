using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Models;

namespace ProFind.Lib.Global.Services
{
    public class PfProcessService :ICrudService<PFProcess>
    {
         public async Task<PFProcess> GetObjectAsync(string id)
        {
            PFProcess process = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Process/{id}");
            if (response.IsSuccessStatusCode)
            {
                process = await response.Content.ReadAsAsync<PFProcess>();
            }

            return process;
        }

        public async Task<IEnumerable<PFProcess>> ListObjectAsync()
        {
            IEnumerable<PFProcess> process = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Process/list");
            if (response.IsSuccessStatusCode)
            {
                process = await response.Content.ReadAsAsync<IEnumerable<PFProcess>>();
            }

            return process;
        }

        public async Task<IEnumerable<PFProcess>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFProcess>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFProcess> process = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Process/list");
            if (response.IsSuccessStatusCode)
            {
                process = await response.Content.ReadAsAsync<IEnumerable<PFProcess>>();
            }

            return process;
        }

        public async Task<IEnumerable<PFProcess>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFProcess> processs = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Process/criteria");
            if (response.IsSuccessStatusCode)
            {
                processs = await response.Content.ReadAsAsync<IEnumerable<PFProcess>>();
            }

            return processs;
        }

        public async Task<HttpStatusCode> Create(PFProcess toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Process", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFProcess toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Process/{toUpdateObject.IdPR}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Process/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}