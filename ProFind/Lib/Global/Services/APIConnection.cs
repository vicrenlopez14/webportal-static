namespace ProFind.Lib.Global.Services
{
    public class APIConnection
    {
        private static WebService _service;

        public static WebService GetConnection { get => _service; }

        public static async void Init()
        {

            _service = new WebService();

        }
    }
}
