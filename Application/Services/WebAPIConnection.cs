using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Application.Services
{
    public class WebAPIConnection
    {
        private static bool _isItRunning;

        private static readonly HttpClient Client = new HttpClient();

        public static HttpClient GetConnection
        {
            get
            {
                if (_isItRunning)
                    return Client;

                RunAsync();
                return Client;
            }
        }


        public static void RunAsync()
        {
            Client.BaseAddress = new Uri("https://localhost:5001/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _isItRunning = true;
        }
    }
}