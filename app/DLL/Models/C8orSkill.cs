using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.DLL.Models
{
    public class C8orSkill
    { 
        public int UserId { get; set; }
        public string SphereId { get; set; }
        public string SkillId { get; set; }
        public virtual Collabor8or? Collabor8or { get; set; }
        public virtual Skill? Skill { get; set; }

    }
}