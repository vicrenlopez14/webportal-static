// ReSharper disable once CheckNamespace
namespace WebService.Models.Generated;

public partial class Client
{
        
}
    
public static class ClientExtensions
{
    // Assign id
    public static void AssignId(this Client client)
    {
        client.IdC = Utils.ShaOperations.GenerateUID();
    }   
}