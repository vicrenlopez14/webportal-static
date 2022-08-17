using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PFProfessionService
    {
        public async Task<(List<PFProfession>, List<string>)> GetComboboxChoices()
        {
            List<PFProfession> professions = new List<PFProfession>();
            List<string> professionStrings = new List<string>();

            professions = (List<PFProfession>) await new PFProfessionService().ListObjectAsync();

            foreach (var profession in professions)
            {
                professionStrings.Add(profession.NamePFS);
            }

            return (professions, professionStrings);
        }

        public async Task<PFProfession> GetObjectAsync(string id)
        {
            PFProfession PFProfession = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Profession/{id}");
            if (response.IsSuccessStatusCode)
            {
                PFProfession = await response.Content.ReadAsAsync<PFProfession>();
            }

            return PFProfession;
        }

        public async Task<IEnumerable<PFProfession>> ListObjectAsync()
        {
            IEnumerable<PFProfession> PFProfession = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Profession/");
            if (response.IsSuccessStatusCode)
            {
                PFProfession = await response.Content.ReadAsAsync<IEnumerable<PFProfession>>();
            }

            return PFProfession;
        }

        public async Task<IEnumerable<PFProfession>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFProfession>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFProfession> PFProfession = null;
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.GetAsync($"api/Profession/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                PFProfession = await response.Content.ReadAsAsync<IEnumerable<PFProfession>>();
            }

            return PFProfession;
        }

        public async Task<IEnumerable<PFProfession>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFProfession> PFProfessions = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Profession/criteria");
            if (response.IsSuccessStatusCode)
            {
                PFProfessions = await response.Content.ReadAsAsync<IEnumerable<PFProfession>>();
            }

            return PFProfessions;
        }

        public async Task<HttpStatusCode> Create(PFProfession toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Profession", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFProfession toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Profession/{toUpdateObject.IdPFS}",
                    toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Profession/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}