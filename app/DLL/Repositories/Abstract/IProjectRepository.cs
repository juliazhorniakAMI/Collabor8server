using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
using app.DLL.Models;
namespace app.DLL.Repositories.Abstract
{
    public interface IProjectRepository
    {
        Task<bool> AddProject(ProjectDTO project);
        Task<bool> UpdateProject(ProjectDTO project);
        Task<bool> DeleteProject(int id);
    }
}