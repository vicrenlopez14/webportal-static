// ReSharper disable once CheckNamespace
namespace WebService.Models.Generated;

public partial class Notification
{
        
}
    
public static class NotificationExtensions
{
    // Assign id
    public static void AssignId(this Notification notification)
    {
        notification.IdN = Utils.ShaOperations.GenerateUID();
    }
}