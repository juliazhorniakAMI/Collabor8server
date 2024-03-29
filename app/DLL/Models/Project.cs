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
            ProjectSupportInfo=new HashSet<ProjectSupportInfo>();
            C8orsProjects = new HashSet<C8orProject>();
            Founders = new HashSet<Founder>();
            ProjectSkill = new HashSet<ProjectSkill>(); 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string SphereId { get; set; }
        public virtual Sphere? Sphere { get; set; }
        public virtual ICollection<ProjectSupportInfo> ProjectSupportInfo { get; set; }
        public virtual ICollection<C8orProject>? C8orsProjects { get; set; }
        public virtual ICollection<Founder> Founders { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkill { get; set; }


    }
}