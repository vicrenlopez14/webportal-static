namespace ProFind.Lib.Global.Services
{
    public class APIConnection
    {
        private static WebServiceClient _service;

        public static WebServiceClient GetConnection { get => _service; }

        public static async void Init()
        {

            _service = new WebServiceClient(new System.Net.Http.HttpClient());

        }
    }
}
