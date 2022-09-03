// ReSharper disable once CheckNamespace
namespace WebService.Models.Generated;

public partial class Projectstatus { }

public static class ProjectStatusExtensions
{
    // Assign id
    public static Projectstatus AssignId(this Projectstatus projectstatus)
    {
        projectstatus.IdPs = Utils.ShaOperations.GenerateUID();
        return projectstatus;
    }
}