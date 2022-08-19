                                                                    using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Application.Services
{
    public class WebAPIConnection
    {
        private static readonly string _endPoint = "http://localhost:5073/";
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

        public static async Task IsServerAlive()
        {
            try
            {
                var results = await new PFAdminService().ListObjectAsync();
                Console.WriteLine();
            }
            catch
            {
                throw new NetworkInformationException();

            }
        }
    }
}