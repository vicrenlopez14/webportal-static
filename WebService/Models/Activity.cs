// ReSharper disable once CheckNamespace

namespace WebService.Models.Generated;

public partial class Activity
{
       
}

public static class ActivityExtension
{
    public static void AssignId(this Activity activity)
    {
        activity.IdAc = Utils.ShaOperations.GenerateUID();
    }
}