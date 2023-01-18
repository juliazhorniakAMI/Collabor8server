using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.C8or;

namespace app.DLL.Mapping
{
     class Collabor8orProfile:Profile
    {  
        public Collabor8orProfile()
        {
              CreateMap<Collabor8or,Collabor8orDTO>()
              .ForMember(r => r.UserName, s => s.MapFrom(t => t.User.Name));
                CreateMap<Collabor8orDTO,Collabor8or>();  
                 CreateMap<Collabor8or,C8orDashboardDTO>().ReverseMap();
        }        
    }
}