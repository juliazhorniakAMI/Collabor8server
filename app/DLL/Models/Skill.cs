using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class Skill
    {
        public Skill()
        {
             ProjectSkill = new HashSet<ProjectSkill>();
             C8orSkill = new HashSet<C8orSkill>();
        }
       public int Id { get; set; }
       public string? FullName { get; set; }
       public virtual ICollection<ProjectSkill> ProjectSkill { get; set; }
       public virtual ICollection<C8orSkill> C8orSkill { get; set; }
    }
}