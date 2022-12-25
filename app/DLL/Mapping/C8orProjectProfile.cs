using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class C8orProjectProfile:Profile
    {
        public C8orProjectProfile()
    {
         CreateMap<C8orProjectDTO, C8orProject>().ReverseMap();
    }
        
    }
}