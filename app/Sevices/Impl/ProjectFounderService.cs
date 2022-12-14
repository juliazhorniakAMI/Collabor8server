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
    public class ProjectFounderService : IProjectFounderService
    {
        private readonly IProjectFounderRepository _Repository;
            public ProjectFounderService(IProjectFounderRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<bool> AddFounderToProject(int founderId, int pjtId)
        {
             return _Repository.AddFounderToProject(founderId,pjtId);
        }

        public Task<bool> DeleteFounderFromProject(int id)
        {
              return _Repository.DeleteFounderFromProject(id);
        }

        public Task<ServiceResponse<List<ProjectFounderDTO>>> GetAllPjtsByFounderId(int founderId)
        {
            return _Repository.GetAllPjtsByFounderId(founderId);
        }

        public Task<ServiceResponse<List<ProjectFounderDTO>>> GetFoundersByProjectId(int pjtId)
        {
             return _Repository.GetFoundersByProjectId(pjtId);
        }
    }
}