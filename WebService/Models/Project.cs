// ReSharper disable once CheckNamespace
namespace WebService.Models.Generated;

public partial class Project { }

public static class ProjectExtension
{
    // Assign id
    public static void AssignId(this Project project)
    {
        project.IdPj = Utils.ShaOperations.GenerateUID();
    }
}