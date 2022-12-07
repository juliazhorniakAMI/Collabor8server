using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class C8orSkill
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int C8orId { get; set; }
        public virtual Skill? Skill { get; set; }
        public virtual Collabor8or? Collabor8or { get; set; }
    }
}