using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class ProjectFounderProfile:Profile
    {
          public ProjectFounderProfile()
        {
              CreateMap<ProjectFounder,ProjectFounderDTO>()
                .ForMember(r => r.FounderName, s => s.MapFrom(t => t.Founder.User.Name))
                .ForMember(r => r.PMName, s => s.MapFrom(t => t.Project.PM.User.Name))
                .ForMember(r => r.ProjectName, s => s.MapFrom(t => t.Project.Name));
           
        }
    }
}