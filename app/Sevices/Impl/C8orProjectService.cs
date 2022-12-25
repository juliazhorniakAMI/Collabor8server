using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class C8orProjectService : IC8orProjectService
    {
        private readonly IC8orProjectRepository _Repository;
        public C8orProjectService(IC8orProjectRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<bool> AddC8orProject(C8orProjectDTO cp)
        {
            return _Repository.AddC8orProject(cp);
        }

        public Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForPjt(Direction direction, int userId)
        {
             return _Repository.GetListC8orsForPjt(direction,userId);
        }

        public Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForC8or(Direction direction, int userId)
        {
           return _Repository.GetListProjectsForC8or(direction,userId);
        }
    }
}