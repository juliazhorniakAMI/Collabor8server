using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ModelsDTO.Skills
{
    public class ProjectSkillDTO
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int ProjectId { get; set; }
        public string Name {get;set;}
        
    }
}