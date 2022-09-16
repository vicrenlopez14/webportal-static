using System;

namespace ProFind.Lib.Global.Services
{
    public class APIConnection
    {
        private static WebServiceClient _service;

        public static WebServiceClient GetConnection { get => _service; }

        public static async void Init()
        {
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000");

            _service = new WebServiceClient(client);
        }
    }
}
