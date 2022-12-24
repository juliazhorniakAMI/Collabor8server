using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Projects;
using AutoMapper;

namespace app.DLL.Mapping.Projects
{
    public class GetProjectProfile:Profile
    {
            public GetProjectProfile()
        {        
            CreateMap<Project, GetProjectDTO>().ReverseMap();
        }
    }
}