// ReSharper disable once CheckNamespace

namespace WebService.Models.Generated;

public partial class Tag
{
}

public static class TagExtensions
{
    // Assign id
    public static void AssignId(this Tag tag)
    {
        tag.IdT = Utils.ShaOperations.GenerateUID();
    }
}