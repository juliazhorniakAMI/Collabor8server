using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class C8orProjectProfile:Profile
    {
        public C8orProjectProfile()
    {
         CreateMap<C8orProjectDTO, C8orProject>();
        
          CreateMap<C8orProject,C8orProjectDTO>()
              .ForMember(r => r.status, s => s.MapFrom(t => t.status.ToString()));
    }
        
    }
}