using Azure.Communication.Email;

namespace WebService.Utils;

public static class EmailClientUtil
{
    private static EmailClient _emailClient;

    // Azure email service authentication
    public static EmailClient GetEmailClient
    {
        get
        {
            if (_emailClient == null)
            {
                Init();
            }

            return _emailClient;
        }
    }

    public static void Init()
    {
        _emailClient =
            new EmailClient(Environment.GetEnvironmentVariable("COMMUNICATION_SERVICES_CONNECTION_STRING"));
    }
}