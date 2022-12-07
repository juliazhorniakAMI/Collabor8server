using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class ProjectFounder
    {
        public int Id { get; set; }
        public int FounderId { get; set; }
        public int ProjectId { get; set; }
        public virtual Founder? Founder { get; set; }
        public virtual Project? Project { get; set; }
    }
}