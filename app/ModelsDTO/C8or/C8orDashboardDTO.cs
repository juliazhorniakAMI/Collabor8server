using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO.Skills;

namespace app.ModelsDTO.C8or
{
    public class C8orDashboardDTO
    {
        
        public int UserId { get; set; }
        public string SphereId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
        public virtual ICollection<C8orProjectDashboardDTO> C8orsProjects { get; set; }
        public virtual ICollection<C8orSkillDTO> C8orSkill { get; set; }

    }
}