using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class ProjectSupportInfo
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Idea {get;set;}
        public virtual Project? Project { get; set; }
    }
}