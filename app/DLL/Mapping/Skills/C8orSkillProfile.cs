using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;
using AutoMapper;

namespace app.DLL.Mapping.Skills
{
    public class C8orSkillProfile:Profile
    {
        public C8orSkillProfile()
        {
             CreateMap<C8orSkill, C8orSkillDTO>().ReverseMap();
        }
    }
}