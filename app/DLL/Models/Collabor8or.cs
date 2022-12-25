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
            C8orsProjects = new HashSet<C8orProject>();
            C8orSkill = new HashSet<C8orSkill>();     
            C8orAccepted4Project= new HashSet<C8orAccepted4Project>();     
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<C8orProject> C8orsProjects { get; set; }
        public virtual ICollection<C8orAccepted4Project> C8orAccepted4Project { get; set; }
        public virtual ICollection<C8orSkill> C8orSkill { get; set; }

    }
}