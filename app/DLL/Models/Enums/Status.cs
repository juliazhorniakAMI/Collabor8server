using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace app.DLL.Models
{
    public enum Status
    {
        Null,
        SeenbyPMFounder,
        SeenbyCollabor8r,
        Rejected,
        ProposalMadebyPMFounder,
        ProposalMadebyCollabor8r,
        ProposalMadebyBoth,
        ProposalAcceptedbyPM,
        ProposalAcceptedbyCollabor8r

    }
}
