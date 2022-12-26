using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace app.DLL.Models
{
    public enum Status
    {
        [Description("Pending")]
        Pending,
        [Description("Accepted")]
        Accepted,
        [Description("Rejected")]
        Rejected
    }
}
