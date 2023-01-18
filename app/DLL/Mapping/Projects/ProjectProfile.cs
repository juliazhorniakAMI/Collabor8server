using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.Projects;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class ProjectProfile:Profile
    {
        public ProjectProfile()
        {
            
            CreateMap<Project, ProjectDTO>().ReverseMap();
              CreateMap<Project, ProjectDashboardDTO>().ReverseMap();
          
        }
        
    }
}