using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;
using AutoMapper;

namespace app.DLL.Mapping.Skills
{
    public class ProjectSkillProfile:Profile
    {
         public ProjectSkillProfile()
        {
             CreateMap<ProjectSkill, ProjectSkillDTO>().ForMember(r => r.Name, s => s.MapFrom(t => t.Skill.Id));
        }
    }
}