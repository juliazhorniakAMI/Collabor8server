using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class PMProfile:Profile
    {
        public PMProfile()
        {
              CreateMap<PM,PMDTO>()
                .ForMember(r => r.Name, s => s.MapFrom(t => t.User.Name));
        }
    }
}