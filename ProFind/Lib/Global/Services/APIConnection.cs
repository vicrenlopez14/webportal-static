using Azure;
using System;
using WebAPI;

namespace ProFind.Lib.Global.Services
{
    public class APIConnection
    {
        private static WebServiceClient _client;

        public static WebServiceClient GetClient { get => _client; }

        public static async void Init()
        {
            _client = new WebServiceClient(new Uri("https://localhost:7073"), new WebServiceClientOptions());
        }
    }
}
