using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class Collabor8or
    {
        public Collabor8or()
        {
            C8orRequsted4Project = new HashSet<C8orRequsted4Project>();
            C8orApplied4Project = new HashSet<C8orApplied4Project>();
            C8orSkill = new HashSet<C8orSkill>();        
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BackgroundSummary { get; set; }
        public string Resume { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<C8orRequsted4Project> C8orRequsted4Project { get; set; }
        public virtual ICollection<C8orApplied4Project> C8orApplied4Project { get; set; }
        public virtual ICollection<C8orSkill> C8orSkill { get; set; }

    }
}