using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace app.DLL.Models
{
    public class Skill
    {
        public Skill()
        {
             ProjectSkill = new HashSet<ProjectSkill>();
             C8orSkill = new HashSet<C8orSkill>();
             SphereSkills = new HashSet<SphereSkill>();
        }
       [Key]
       public string Id { get; set; }
       public virtual ICollection<SphereSkill> SphereSkills { get; set; }
       public virtual ICollection<ProjectSkill> ProjectSkill { get; set; }
       public virtual ICollection<C8orSkill> C8orSkill { get; set; }
    }
}