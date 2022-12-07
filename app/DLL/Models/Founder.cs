using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class Founder
    {
        public Founder()
        {
             ProjectFounder = new HashSet<ProjectFounder>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BackgroundSummary { get; set; }
        public string Resume { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProjectFounder> ProjectFounder { get; set; }
      
    }
}