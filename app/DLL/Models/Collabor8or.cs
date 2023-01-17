using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.DLL.Models
{
    public class Collabor8or
    {
        public Collabor8or()
        {
            C8orsProjects = new HashSet<C8orProject>();
            C8orSkill = new HashSet<C8orSkill>();
        }
        public int UserId { get; set; }
        public string SphereId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
        public virtual User? User { get; set; }
        public virtual Sphere? Sphere { get; set; }
        public virtual ICollection<C8orProject> C8orsProjects { get; set; }
        public virtual ICollection<C8orSkill> C8orSkill { get; set; }

    }
}