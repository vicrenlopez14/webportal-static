using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Services
{
    public class PFNotificationService
    {
        public async Task<PFNotification> GetObjectAsync(string id)
        {
            PFNotification Notification = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Notification/{id}");
            if (response.IsSuccessStatusCode)
            {
                Notification = await response.Content.ReadAsAsync<PFNotification>();
            }

            return Notification;
        }

        public async Task<IEnumerable<PFNotification>> ListObjectAsync()
        {
            IEnumerable<PFNotification> Notification = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Notification/");
            if (response.IsSuccessStatusCode)
            {
                Notification = await response.Content.ReadAsAsync<IEnumerable<PFNotification>>();
            }

            return Notification;
        }

        public async Task<IEnumerable<PFNotification>> ListPaginatedObjectAsync(int fromIndex) =>
            await ListPaginatedObjectAsync(fromIndex, -1);

        public async Task<IEnumerable<PFNotification>> ListPaginatedObjectAsync(int fromIndex, int toIndex)
        {
            IEnumerable<PFNotification> Notification = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync($"api/Notification/paginated/{fromIndex}/{toIndex}");
            if (response.IsSuccessStatusCode)
            {
                Notification = await response.Content.ReadAsAsync<IEnumerable<PFNotification>>();
            }

            return Notification;
        }

        public async Task<IEnumerable<PFNotification>> Search(IDictionary<string, string> searchCriteria)
        {
            IEnumerable<PFNotification> Notifications = null;
            HttpResponseMessage response = await WebAPIConnection.GetConnection.GetAsync("api/Notification/criteria");
            if (response.IsSuccessStatusCode)
            {
                Notifications = await response.Content.ReadAsAsync<IEnumerable<PFNotification>>();
            }

            return Notifications;
        }

        public async Task<HttpStatusCode> Create(PFNotification toCreateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PostAsJsonAsync("api/Notification", toCreateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Update(PFNotification toUpdateObject)
        {
            HttpResponseMessage response =
                await WebAPIConnection.GetConnection.PutAsJsonAsync($"api/Notification/{toUpdateObject.IdN}",
                    toUpdateObject);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> Delete(string id)
        {
            HttpResponseMessage response = await WebAPIConnection.GetConnection.DeleteAsync($"api/Notification/{id}");
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
    }
}