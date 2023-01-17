using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.DLL.Models
{
    public class ProjectSkill
    {
        public string SkillId { get; set; }
        public int ProjectId { get; set; }
        public virtual Skill? Skill { get; set; }
        public virtual Project? Project { get; set; }
    }
}