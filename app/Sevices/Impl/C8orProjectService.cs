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
        public Task<ServiceResponse<bool>> AddC8orProject(C8orProjectDTO cp)
        {
            return _Repository.AddC8orProject(cp);
        }
        public Task<bool> DeleteC8orProject(int UserId,string sphereId,int pjtId)
        {
            return _Repository.DeleteC8orProject(UserId,sphereId,pjtId);
        }
        public Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForAllPjt(Direction direction, int userId)
        {
             return _Repository.GetListC8orsForAllPjt(direction,userId);
        }

        public Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForOnePjt(Direction direction, int pId)
        {
            return _Repository.GetListC8orsForOnePjt( direction, pId);
        }

        public Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForAllC8or(Direction direction, int userId)
        {
           return _Repository.GetListProjectsForAllC8or(direction,userId);
        }

        public Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForOneC8or(Direction direction, int c8orId)
        {
            return _Repository.GetListProjectsForOneC8or( direction, c8orId);
        }

        public Task<bool> UpdateC8orPjtStatus(int cpId,Status status)
        {
             return _Repository.UpdateC8orPjtStatus( cpId, status);
        }
    }
}