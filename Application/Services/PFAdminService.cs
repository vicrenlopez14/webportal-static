using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Application.Models;
using HttpResponseMessage = System.Net.Http.HttpResponseMessage;
using HttpStatusCode = System.Net.HttpStatusCode;

namespace Application.Services
{
    public class PFAdminService : ICrudService<PFAdmin>
    {
        private PFAdmin loggedAdmin;

        public async Task<HttpStatusCode> Login(string email, string password)
        {
            var loginAdmin = new RegisterClient
            {
                EmailC = email,
                PasswordC = password
            };


            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync($"api/Admin/login", loginAdmin);

            if (response.IsSuccessStatusCode)
            {
                loggedAdmin = await response.Content.ReadAsAsync<PFAdmin>();
            }

            return response.StatusCode;
        }

        public async Task<PFAdmin> GetObjectAsync(string id)
        {
            PFAdmin admin = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Admin/{id}");
            if (response.IsSuccessStatusCode)
            {
                admin = await response.Content.ReadAsAsync<PFAdmin>();
            }

            return admin;
        }

        public async Task<IEnumerable<PFAdmin>> ListObjectAsync()
        {
            IEnumerable<PFAdmin> admin = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Admin/");
            if (response.IsSuccessStatusCode)
            {
                admin = await response.Content.ReadAsAsync<IEnumerable<PFAdmin>>();
            }

            return admin;
        }

        public async Task<IEnumerable<PFAdmin>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFAdmin>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFAdmin> admin = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/Admin/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                admin = await response.Content.ReadAsAsync<IEnumerable<PFAdmin>>();
            }
            else
            {
                throw new NetworkInformationException();
            }

            return admin;
        }

        public async Task<IEnumerable<PFAdmin>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFAdmin> admins = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Admin/criteria");
            if (response.IsSuccessStatusCode)
            {
                admins = await response.Content.ReadAsAsync<IEnumerable<PFAdmin>>();
            }

            return admins;
        }

        public async Task<HttpStatusCode> Create(PFAdmin toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Admin", toCreateObject);

            return response.StatusCode;
        }

        public async Task<bool> AreThereAdmins()
        {
            IEnumerable<PFAdmin> admins = new List<PFAdmin>();
            try
            {
                HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Admin/");
                if (response.IsSuccessStatusCode)
                {
                    admins = await response.Content.ReadAsAsync<IEnumerable<PFAdmin>>();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            return admins.Any();
        }

        public async Task<HttpStatusCode> Update(PFAdmin toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Admin/{toUpdateObject.IdA}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Admin/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}