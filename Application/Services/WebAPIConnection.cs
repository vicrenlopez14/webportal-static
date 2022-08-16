using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Application.Services
{
    public class WebAPIConnection
    {
        private static string _endPoint = "http://localhost:5073/";
        private static bool _isItRunning;
        private static HttpClient Client;

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
         
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            Client = new HttpClient(httpClientHandler) { BaseAddress = new Uri(_endPoint) };


            Client.BaseAddress = new Uri(_endPoint);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _isItRunning = true;
        }
    }
}