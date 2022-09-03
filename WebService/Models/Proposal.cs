// ReSharper disable once CheckNamespace
namespace WebService.Models.Generated;

public partial class Proposal { }

public static class ProposalExtensions
{
    // Assign id
    public static Proposal AssignId(this Proposal proposal)
    {
        proposal.IdPp = Utils.ShaOperations.GenerateUID();
        return proposal;
    }
}