using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using app.DLL.Models;
using app.ModelsDTO;

namespace app.DLL.Mapping
{
     class Collabor8orProfile:Profile
    {  
        public Collabor8orProfile()
        {
              CreateMap<Collabor8or,Collabor8orDTO>()
              .ForMember(r => r.Name, s => s.MapFrom(t => t.User.Name));
        
        }        
    }
}