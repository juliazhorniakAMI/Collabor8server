using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class PM
    {
        public PM()
        {
            Project = new HashSet<Project>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BackgroundSummary { get; set; }
        public string Resume { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}