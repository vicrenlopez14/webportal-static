using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Application.Services
{
    public class WebAPIConnection
    {
        private static HttpClient client = new HttpClient();

        public static HttpClient GetConnection => client;

        public static void RunAsync()
        {
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}