using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI;

namespace ProFind.Lib.Global.Services
{
    public class APIConnection
    {
        private static WebServiceClient _client;

        static WebServiceClient GetClient { get => _client; }

        public static void Init()
        {
            _client = new WebServiceClient(new Uri("https://localhost:7073"), new WebServiceClientOptions());
        }
    }
}
