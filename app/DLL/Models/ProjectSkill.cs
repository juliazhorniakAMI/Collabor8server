using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class ProjectSkill
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int ProjectId { get; set; }
        public virtual Skill? Skill { get; set; }
        public virtual Project? Project { get; set; }
    }
}