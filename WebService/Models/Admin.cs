// ReSharper disable once CheckNamespace

namespace WebService.Models.Generated;

public partial class Admin
{
}

public static class AdminExtensions
{
    // Assign id
    public static void AssignId(this Admin admin)
    {
        admin.IdA = Utils.ShaOperations.GenerateUID();
    }
}