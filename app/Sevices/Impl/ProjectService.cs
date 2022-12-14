using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class ProjectService : IProjectService
    {
         private readonly IProjectRepository _Repository;
            public ProjectService(IProjectRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<bool> AddProject(ProjectDTO project)
        {
             return _Repository.AddProject(project);
        }
        public Task<bool> DeleteProject(int id)
        {
           return _Repository.DeleteProject(id);
        }
        public Task<bool> UpdateProject(ProjectDTO project)
        {
            return _Repository.UpdateProject(project);
        }
    }
}