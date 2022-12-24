using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.Projects;
using app.ModelsDTO.Founders;

namespace app.Sevices.Abstract
{
    public interface IProjectService
    {
        Task<ServiceResponse<List<GetProjectDTO>>> GetAllProjects();
        Task<ServiceResponse<ProjectDTO>> GetProjectById(int pjtid);
        Task<bool> AddProject(ProjectDTO project);
        Task<bool> UpdateProject(ProjectDTO project);
        Task<bool> DeleteProject(int id);
    }
}