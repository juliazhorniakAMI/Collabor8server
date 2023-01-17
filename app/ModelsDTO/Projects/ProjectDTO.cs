using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;

namespace app.ModelsDTO
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string SphereId { get; set; }
        public virtual ICollection<ProjectSupportInfoDTO> ProjectSupportInfo { get; set; }
        public virtual ICollection<FounderDTO> Founders { get; set; }
        public virtual ICollection<ProjectSkillDTO> ProjectSkill { get; set; }
       
    }
}