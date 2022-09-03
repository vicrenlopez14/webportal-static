// ReSharper disable once CheckNamespace

namespace WebService.Models.Generated;

public partial class Professional
{
}

public static class ProfessionalExtensions
{
    // Assign id
    public static void AssignId(this Professional professional)
    {
        professional.IdP = Utils.ShaOperations.GenerateUID();
    }
}