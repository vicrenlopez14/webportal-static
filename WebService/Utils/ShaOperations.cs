using System.Security.Cryptography;
using System.Text;

namespace WebService.Utils;

public class ShaOperations
{
    public static string ShaPassword(string password)
    {
        if (String.IsNullOrEmpty(password))
            return String.Empty;
        
        using HashAlgorithm algorithm = SHA512.Create();
        return Encoding.UTF8.GetString(algorithm.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }

    public static string GenerateUID()
    {
        using HashAlgorithm algorithm = SHA512.Create();
        return Encoding.UTF8.GetString(algorithm.ComputeHash(Encoding.UTF8.GetBytes(Guid.NewGuid().ToString())));
    }
}