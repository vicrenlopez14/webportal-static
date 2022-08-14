using System.Security.Cryptography;
using System.Text;

namespace WebService.Utils;

public class SHAPassword
{
    public static string ShaThisPassword(string password)
    {
        using HashAlgorithm algorithm = SHA512.Create();
        return Encoding.UTF8.GetString(algorithm.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }
}