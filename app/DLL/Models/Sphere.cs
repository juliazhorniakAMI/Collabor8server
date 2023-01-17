using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace app.DLL.Models
{
    public class Sphere
    {
         public Sphere()
        {
             Projects = new HashSet<Project>();
             Collabor8ors = new HashSet<Collabor8or>();
             SphereSkills = new HashSet<SphereSkill>();
        }
        [Key]
        public string Id { get; set; }
        public virtual ICollection<SphereSkill> SphereSkills { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Collabor8or> Collabor8ors { get; set; }
        
    }
}