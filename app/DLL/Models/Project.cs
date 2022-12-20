using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class Project
    {
        public Project()
        {
            C8orRequsted4Project = new HashSet<C8orRequsted4Project>();
            C8orApplied4Project = new HashSet<C8orApplied4Project>();
            Founders = new HashSet<Founder>();
            ProjectSkill = new HashSet<ProjectSkill>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Ideas { get; set; }
        public string Contracts { get; set; }
        public virtual ICollection<C8orRequsted4Project> C8orRequsted4Project { get; set; }
        public virtual ICollection<C8orApplied4Project> C8orApplied4Project { get; set; }
        public virtual ICollection<Founder> Founders { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkill { get; set; }

    }
}