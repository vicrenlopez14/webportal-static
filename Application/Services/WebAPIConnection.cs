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

                Run();
                return Client;
            }
        }


        public static void Run()
        {
            Client.BaseAddress = new Uri("http://localhost:5073/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _isItRunning = true;
        }
    }
}