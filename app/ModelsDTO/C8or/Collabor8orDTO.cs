using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;

namespace app.ModelsDTO
{
    public class Collabor8orDTO
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string SphereId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
        public virtual ICollection<C8orSkillDTO> C8orSkill { get; set; }
      
    }
}