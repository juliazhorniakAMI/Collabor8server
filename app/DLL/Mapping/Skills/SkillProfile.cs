using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping.Skills
{
    public class SkillProfile:Profile
    {
        public SkillProfile()
        {
              CreateMap<Skill, SkillDTO>().ReverseMap();
        }
    }
}