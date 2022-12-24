using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Founders;
using AutoMapper;

namespace app.DLL.Mapping.Founders
{
    public class FoundersForProjectProfile:Profile
    {
         public FoundersForProjectProfile()
        {
             CreateMap<Founder,FoundersForProjectDTO>()
                .ForMember(r => r.Name, s => s.MapFrom(t => t.User.Name));
              CreateMap<FoundersForProjectDTO,Founder>();     
        }
    }
}