using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.Founders;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class FounderProfile:Profile
    {
           public FounderProfile()
        {
              CreateMap<Founder,FounderDTO>()
                .ForMember(r => r.Name, s => s.MapFrom(t => t.User.Name));
              CreateMap<FounderDTO,Founder>();
              CreateMap<Founder,FounderDashboardDTO>().ReverseMap();
        }
    }
}