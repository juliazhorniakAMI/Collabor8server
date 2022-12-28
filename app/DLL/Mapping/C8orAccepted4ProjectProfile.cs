using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class C8orAccepted4ProjectProfile:Profile
    {
        public C8orAccepted4ProjectProfile()
        { 
             CreateMap<C8orAccepted4ProjectDTO, C8orAccepted4Project>().ReverseMap();
            
        }
        
    }
}