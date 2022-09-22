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

public static class TagDurationDirtyTrick
{
    public static string ToTagDurationReadable(this int latag)
    {
        if (latag == 0)
        {
            return "Short";
        } 
        else if(latag == 1)
        {
            return "Medium";
        }
        else
        {
            return "Large";
        }
    }
}