﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Services
{
    public class PfClientService: ICrudService<PFClient>
    {
        public async Task<HttpStatusCode> Login(string email, string password)
        {
            var values = new Dictionary<string, string>
            {
                {"email", email},
                {"password", password}
            };

            var content = new FormUrlEncodedContent(values);

            var response = await WebAPIConnection.GetConnection.PostAsync($"api/Client/login", content);

            return response.StatusCode;
        }
        
        public async Task<HttpStatusCode> Register(RegisterClient toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Client", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        
         public async Task<PFClient> GetObjectAsync(string id)
        {
            PFClient client = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Client/{id}");
            if (response.IsSuccessStatusCode)
            {
                client = await response.Content.ReadAsAsync<PFClient>();
            }

            return client;
        }

        public async Task<IEnumerable<PFClient>> ListObjectAsync()
        {
            IEnumerable<PFClient> client = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Client/list");
            if (response.IsSuccessStatusCode)
            {
                client = await response.Content.ReadAsAsync<IEnumerable<PFClient>>();
            }

            return client;
        }

        public async Task<IEnumerable<PFClient>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFClient>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFClient> client = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Client/list");
            if (response.IsSuccessStatusCode)
            {
                client = await response.Content.ReadAsAsync<IEnumerable<PFClient>>();
            }

            return client;
        }

        public async Task<IEnumerable<PFClient>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFClient> clients = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Client/criteria");
            if (response.IsSuccessStatusCode)
            {
                clients = await response.Content.ReadAsAsync<IEnumerable<PFClient>>();
            }

            return clients;
        }

        public async Task<HttpStatusCode> Create(PFClient toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Client", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFClient toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Client/{toUpdateObject.IdC}", toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Client/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}