using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
namespace app.Sevices.Abstract
{
    public interface IProjectService
    {
        Task<bool> AddProject(ProjectDTO project);
        Task<bool> UpdateProject(ProjectDTO project);
        Task<bool> DeleteProject(int id);
    }
}